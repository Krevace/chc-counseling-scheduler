using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MongoDB.Driver;
using MongoDB.Bson;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;

namespace CollegeSchedulingDesktopAppMain
{
    public partial class FormPending : Form
    {
        Thread t;
        System.Windows.Forms.Timer timer1;
        CalendarService service;
        bool run = true;
        bool timerRun = true;
        bool equals = false;
        string gMail;
        string cName;
        static MongoClient dbClient = new MongoClient("mongodb+srv://admin:##############");
        static IMongoDatabase database = dbClient.GetDatabase("myFirstDatabase");
        static IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("appointments");
        List<BsonDocument> firstDocument = collection.Find(new BsonDocument()).ToList();
        List<BsonDocument> oldDocument;

        public FormPending(CalendarService servicePass, string gMailPass)
        {
            InitializeComponent();
            service = servicePass;
            gMail = gMailPass;
            if (gMail == "##############")
            {
                cName = "##############";
            }
            else if (gMail == "##############")
            {
                cName = "##############";
            }
            else if (gMail == "##############")
            {
                cName = "##############";
            }
            else if (gMail == "##############")
            {
                cName = "##############";
            }
            else if (gMail == "##############")
            {
                cName = "##############";
            }
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            InitTimer();
            t = new Thread(() => DoThisAllTheTime(panelMeetings));
            t.IsBackground = true;
            t.Start();
        }

        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 3000; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerRun = true;
        }

        private void DoThisAllTheTime(Control control)
        {
            while (run)
            {
                firstDocument = collection.Find(new BsonDocument()).ToList();
                if (this.IsHandleCreated && !control.IsDisposed && timerRun)
                {
                    timerRun = false;
                    control.Invoke(new DoThisAllTheTimeDelegate(DoThisAllTheTimeFunction), new object[] { control });
                }
            }
            t.Abort();
        }

        public delegate void DoThisAllTheTimeDelegate(Control control);

        private void DoThisAllTheTimeFunction(Control control)
        {
            if (oldDocument != null)
            {
                if (firstDocument.Count != oldDocument.Count)
                {
                    equals = false;
                }
                else
                {
                    for (int i = 0; i < firstDocument.Count; i++)
                    {
                        if (firstDocument[i].Equals(oldDocument[i]))
                        {
                            equals = true;
                        } 
                        else
                        {
                            equals = false;
                            i = firstDocument.Count;
                        }
                    }
                }
            }

            if (!equals)
            {
                int count = 0;
                int count2 = 0;
                control.Controls.Clear();
                Color color = Color.White;
                Font labelFont = new Font("Gadugi", 8.25f, FontStyle.Bold);
                Font labelFont2 = new Font("Gadugi", 9.75f, FontStyle.Bold);
                Font labelFont3 = new Font("Rockwell", 14f, FontStyle.Bold);
                Font labelFont4 = new Font("Rockwell", 12f, FontStyle.Regular);
                for (int i = 0; i < firstDocument.Count; i++)
                {
                    int currentPos = new int();
                    currentPos = i;
                    if (firstDocument[i]["Status"].AsString == "pending" && firstDocument[i]["Counselor"].AsString == cName)
                    {
                        Panel panel = new Panel
                        {
                            BorderStyle = BorderStyle.None,
                            BackColor = color,
                            Width = Convert.ToInt32(control.Width * .7),
                            Location = new Point(Convert.ToInt32(control.Width * .15), Convert.ToInt32(control.Height * .2 * (i - count)))
                        };
                        Label labelName = new Label
                        {
                            Text = firstDocument[i]["Name"].AsString,
                            Font = labelFont,
                            Location = new Point(Convert.ToInt32(panel.Width * .07), Convert.ToInt32(panel.Height * .1))
                        };
                        Label labelDate = new Label
                        {
                            Text = firstDocument[i]["Date"].ToUniversalTime().ToString(),
                            Height = 30,
                            Width = 80,
                            Font = labelFont,
                            Location = new Point(Convert.ToInt32(panel.Width * .3), Convert.ToInt32(panel.Height * .1))
                        };
                        Label labelEndDate = new Label
                        {
                            Text = firstDocument[i]["EndTime"].ToUniversalTime().ToString(),
                            Height = 30,
                            Width = 80,
                            Font = labelFont,
                            Location = new Point(Convert.ToInt32(panel.Width * .47), Convert.ToInt32(panel.Height * .1))
                        };
                        Label labelMessage = new Label
                        {
                            Text = firstDocument[i]["Message"].AsString,
                            Height = 30,
                            Width = 280,
                            Location = new Point(Convert.ToInt32(panel.Width * .07), Convert.ToInt32(panel.Height * .52))
                        };
                        Button buttonAccept = new Button()
                        {
                            BackgroundImage = Properties.Resources.acceptButton,
                            BackgroundImageLayout = ImageLayout.Stretch,
                            FlatStyle = FlatStyle.Flat,
                            ForeColor = Color.Transparent,
                            Width = 43,
                            Height = 43,
                            Location = new Point(Convert.ToInt32(panel.Width * .66), Convert.ToInt32(panel.Height * .05))
                        };
                        buttonAccept.FlatAppearance.MouseOverBackColor = Color.Transparent;
                        buttonAccept.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        buttonAccept.FlatAppearance.BorderSize = 0;
                        Button buttonModify = new Button()
                        {
                            BackgroundImage = Properties.Resources.modifyButton,
                            BackgroundImageLayout = ImageLayout.Stretch,
                            FlatStyle = FlatStyle.Flat,
                            ForeColor = Color.Transparent,
                            Width = 43,
                            Height = 43,
                            Location = new Point(Convert.ToInt32(panel.Width * .77), Convert.ToInt32(panel.Height * .05))
                        };
                        buttonModify.FlatAppearance.MouseOverBackColor = Color.Transparent;
                        buttonModify.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        buttonModify.FlatAppearance.BorderSize = 0;
                        Button buttonDeny = new Button()
                        {
                            BackgroundImage = Properties.Resources.denyButton,
                            BackgroundImageLayout = ImageLayout.Stretch,
                            FlatStyle = FlatStyle.Flat,
                            ForeColor = Color.Transparent,
                            Width = 43,
                            Height = 43,
                            Location = new Point(Convert.ToInt32(panel.Width * .88), Convert.ToInt32(panel.Height * .05))
                        };
                        buttonDeny.FlatAppearance.MouseOverBackColor = Color.Transparent;
                        buttonDeny.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        buttonDeny.FlatAppearance.BorderSize = 0;

                        buttonAccept.Click += (object sender, EventArgs e) =>
                        {
                            EventDateTime start = new EventDateTime()
                            {
                                DateTime = Convert.ToDateTime(firstDocument[currentPos]["Date"].ToString().Replace("Z", ""))
                            };
                            EventDateTime end = new EventDateTime()
                            {
                                DateTime = Convert.ToDateTime(firstDocument[currentPos]["EndTime"].ToString().Replace("Z", ""))
                            };
                            Event meeting = new Event()
                            {
                                Start = start,
                                End = end,
                                Summary = "Meeting with " + firstDocument[currentPos]["Name"].AsString
                            };
                            EventsResource.InsertRequest request = new EventsResource.InsertRequest(service, meeting, gMail);
                            request.Execute();

                            var filter = Builders<BsonDocument>.Filter.Eq("_id", firstDocument[currentPos]["_id"]);
                            var update = Builders<BsonDocument>.Update.Set("Status", "accepted");
                            collection.UpdateOne(filter, update);

                            timerRun = true;
                        };
                        buttonModify.Click += (object sender, EventArgs e) =>
                        {
                            Panel panelPopup = new Panel()
                            {
                                BorderStyle = BorderStyle.FixedSingle,
                                BackColor = Color.White,
                                Width = Convert.ToInt32(control.Width * .5),
                                Height = Convert.ToInt32(control.Height * .5),
                                Location = new Point(Convert.ToInt32(control.Width * .25), Convert.ToInt32(control.Height * .20))
                            };
                            Label labelTitle = new Label()
                            {
                                Text = "Modify Meeting",
                                Width = 400,
                                Height = 50,
                                Font = new Font(Font.FontFamily, 24, FontStyle.Bold),
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .14), Convert.ToInt32(panelPopup.Height * .1))
                            };
                            DateTimePicker dateTimePickerStartDate = new DateTimePicker()
                            {
                                Format = DateTimePickerFormat.Custom,
                                CustomFormat = "MM/dd/yyyy hh:mm:ss tt",
                                Text = firstDocument[currentPos]["Date"].ToUniversalTime().ToString(),
                                Font = labelFont,
                                ShowUpDown = true,
                                Width = 145,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .28), Convert.ToInt32(panelPopup.Height * .4))
                            };
                            Label labelDuration = new Label()
                            {
                                Text = "Duration:",
                                Font = labelFont2,
                                Width = 67,
                                Height = 17,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .33), Convert.ToInt32(panelPopup.Height * .5))
                            };
                            Label label10Error = new Label()
                            {
                                Visible = false,
                                Text = "Cannot be\nWithin\nthe Next\n10 Minutes",
                                Width = 89,
                                Height = 76,
                                Font = labelFont4,
                                ForeColor = Color.Red,
                                TextAlign = ContentAlignment.TopCenter,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .01), Convert.ToInt32(panelPopup.Height * .33))
                            };
                            Label labelOccupiedError = new Label()
                            {
                                Visible = false,
                                Text = "This Time\nis Already\nTaken",
                                Width = 83,
                                Height = 57,
                                Font = labelFont4,
                                ForeColor = Color.Red,
                                TextAlign = ContentAlignment.TopCenter,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .73), Convert.ToInt32(panelPopup.Height * .38))
                            };
                            ComboBox comboBoxDuration = new ComboBox()
                            {
                                DropDownStyle = ComboBoxStyle.DropDownList,
                                SelectedItem = "10",
                                DataSource = new List<string>() {"10","20","30","40","60"},
                                Font = labelFont,
                                Width = 36,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .53), Convert.ToInt32(panelPopup.Height * .5))
                            };
                            Button buttonOk = new Button()
                            {
                                BackgroundImage = Properties.Resources.acceptButton,
                                BackgroundImageLayout = ImageLayout.Stretch,
                                FlatStyle = FlatStyle.Flat,
                                ForeColor = Color.Transparent,
                                Width = 43,
                                Height = 43,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .2), Convert.ToInt32(panelPopup.Height * .75))
                            };
                            buttonOk.FlatAppearance.MouseOverBackColor = Color.Transparent;
                            buttonOk.FlatAppearance.MouseDownBackColor = Color.Transparent;
                            buttonOk.FlatAppearance.BorderSize = 0;
                            Button buttonCancel = new Button()
                            {
                                BackgroundImage = Properties.Resources.denyButton,
                                BackgroundImageLayout = ImageLayout.Stretch,
                                FlatStyle = FlatStyle.Flat,
                                ForeColor = Color.Transparent,
                                Width = 43,
                                Height = 43,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .65), Convert.ToInt32(panelPopup.Height * .75))
                            };
                            buttonCancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
                            buttonCancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
                            buttonCancel.FlatAppearance.BorderSize = 0;

                            buttonOk.Click += (object sender2, EventArgs e2) =>
                            {
                                if (dateTimePickerStartDate.Text != "" && DateTime.Now.AddMinutes(10) < Convert.ToDateTime(dateTimePickerStartDate.Text))
                                {
                                    label10Error.Visible = false;
                                    bool valid = true;
                                    DateTime startTime = Convert.ToDateTime(dateTimePickerStartDate.Text);
                                    DateTime endTime = Convert.ToDateTime(dateTimePickerStartDate.Text).AddMinutes(Convert.ToInt32(comboBoxDuration.Text));
                                    EventsResource.ListRequest request = new EventsResource.ListRequest(service, "primary");
                                    request.SingleEvents = true;
                                    request.TimeMin = startTime;
                                    request.TimeMax = endTime;
                                    Events events = request.Execute();
                                    if (events.Items != null && events.Items.Count > 0)
                                    {
                                        foreach (var eventItem in events.Items)
                                        {
                                            if (eventItem.Start.DateTime >= startTime && eventItem.Start.DateTime <= endTime)
                                            {
                                                valid = false;
                                            } else if (eventItem.End.DateTime >= startTime && eventItem.End.DateTime <= endTime)
                                            {
                                                valid = false;
                                            }
                                        }
                                    }
                                    
                                    if (valid)
                                    {
                                        labelOccupiedError.Visible = false;
                                        var filter = Builders<BsonDocument>.Filter.Eq("_id", firstDocument[currentPos]["_id"]);
                                        var update = Builders<BsonDocument>.Update.Set("Date", Convert.ToDateTime(dateTimePickerStartDate.Text).ToLocalTime());
                                        var update2 = Builders<BsonDocument>.Update.Set("EndTime", Convert.ToDateTime(dateTimePickerStartDate.Text).AddMinutes(Convert.ToInt32(comboBoxDuration.Text)).ToLocalTime());
                                        var update3 = Builders<BsonDocument>.Update.Set("Status", "modified");
                                        collection.UpdateOne(filter, update);
                                        collection.UpdateOne(filter, update2);
                                        collection.UpdateOne(filter, update3);

                                        panelPopup.Dispose();
                                        timerRun = true;
                                    } else
                                    {
                                        labelOccupiedError.Visible = true;
                                    }
                                } else
                                {
                                    label10Error.Visible = true;
                                }
                            };
                            buttonCancel.Click += (object sender2, EventArgs e2) =>
                            {
                                panelPopup.Dispose();
                                
                                var filter = Builders<BsonDocument>.Filter.Eq("_id", firstDocument[currentPos]["_id"]);
                                if (firstDocument[currentPos]["__v"] == 0)
                                {
                                    var update = Builders<BsonDocument>.Update.Set("__v", 1);
                                    collection.UpdateOne(filter, update);
                                } 
                                else
                                {
                                    var update = Builders<BsonDocument>.Update.Set("__v", 0);
                                    collection.UpdateOne(filter, update);
                                }
                                timerRun = true;
                            };

                            control.Controls.Clear();
                            control.Controls.Add(panelPopup);
                            panelPopup.Controls.Add(labelTitle);
                            panelPopup.Controls.Add(dateTimePickerStartDate);
                            panelPopup.Controls.Add(labelDuration);
                            panelPopup.Controls.Add(label10Error);
                            panelPopup.Controls.Add(labelOccupiedError);
                            panelPopup.Controls.Add(comboBoxDuration);
                            panelPopup.Controls.Add(buttonOk);
                            panelPopup.Controls.Add(buttonCancel);
                        };
                        buttonDeny.Click += (object sender, EventArgs e) =>
                        {
                            var filter = Builders<BsonDocument>.Filter.Eq("_id", firstDocument[currentPos]["_id"]);
                            var update = Builders<BsonDocument>.Update.Set("Status", "denied");
                            collection.UpdateOne(filter, update);

                            timerRun = true;
                        };

                        control.Controls.Add(panel);
                        panel.Controls.Add(labelName);
                        panel.Controls.Add(labelDate);
                        panel.Controls.Add(labelEndDate);
                        panel.Controls.Add(labelMessage);
                        panel.Controls.Add(buttonAccept);
                        panel.Controls.Add(buttonModify);
                        panel.Controls.Add(buttonDeny);
                        if (color == Color.White)
                        {
                            color = ColorTranslator.FromHtml("#f9f9f9");
                        } else
                        {
                            color = Color.White;
                        }
                        count2++;
                    }
                    else
                    {
                        count++;
                    }
                }
                count = 0;
                for (int i = 0; i < firstDocument.Count; i++)
                {
                    int currentPos = new int();
                    currentPos = i;
                    if (firstDocument[i]["Status"].AsString == "accepted" && firstDocument[i]["Counselor"].AsString == cName)
                    {
                        Panel panel = new Panel
                        {
                            BorderStyle = BorderStyle.None,
                            BackColor = color,
                            Width = Convert.ToInt32(control.Width * .7),
                            Location = new Point(Convert.ToInt32(control.Width * .15), Convert.ToInt32(control.Height * .2 * (i - count + count2)))
                        };
                        Label labelName = new Label
                        {
                            Text = firstDocument[i]["Name"].AsString,
                            Font = labelFont,
                            Location = new Point(Convert.ToInt32(panel.Width * .07), Convert.ToInt32(panel.Height * .1))
                        };
                        Label labelDate = new Label
                        {
                            Text = firstDocument[i]["Date"].ToUniversalTime().ToString(),
                            Height = 30,
                            Width = 80,
                            Font = labelFont,
                            Location = new Point(Convert.ToInt32(panel.Width * .3), Convert.ToInt32(panel.Height * .1))
                        };
                        Label labelEndDate = new Label
                        {
                            Text = firstDocument[i]["EndTime"].ToUniversalTime().ToString(),
                            Height = 30,
                            Width = 80,
                            Font = labelFont,
                            Location = new Point(Convert.ToInt32(panel.Width * .47), Convert.ToInt32(panel.Height * .1))
                        };
                        Label labelMessage = new Label
                        {
                            Text = firstDocument[i]["Message"].AsString,
                            Height = 30,
                            Width = 280,
                            Location = new Point(Convert.ToInt32(panel.Width * .07), Convert.ToInt32(panel.Height * .52))
                        };
                        Label labelUpcoming = new Label
                        {
                            Text = "Upcoming",
                            Height = 25,
                            Width = 108,
                            ForeColor = Color.MediumSeaGreen,
                            Font = labelFont3,
                            Location = new Point(Convert.ToInt32(panel.Width * .76), Convert.ToInt32(panel.Height * .62))
                        };
                        Button buttonModify = new Button()
                        {
                            BackgroundImage = Properties.Resources.modifyButton,
                            BackgroundImageLayout = ImageLayout.Stretch,
                            FlatStyle = FlatStyle.Flat,
                            ForeColor = Color.Transparent,
                            Width = 43,
                            Height = 43,
                            Location = new Point(Convert.ToInt32(panel.Width * .77), Convert.ToInt32(panel.Height * .05))
                        };
                        buttonModify.FlatAppearance.MouseOverBackColor = Color.Transparent;
                        buttonModify.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        buttonModify.FlatAppearance.BorderSize = 0;
                        Button buttonDeny = new Button()
                        {
                            BackgroundImage = Properties.Resources.denyButton,
                            BackgroundImageLayout = ImageLayout.Stretch,
                            FlatStyle = FlatStyle.Flat,
                            ForeColor = Color.Transparent,
                            Width = 43,
                            Height = 43,
                            Location = new Point(Convert.ToInt32(panel.Width * .88), Convert.ToInt32(panel.Height * .05))
                        };
                        buttonDeny.FlatAppearance.MouseOverBackColor = Color.Transparent;
                        buttonDeny.FlatAppearance.MouseDownBackColor = Color.Transparent;
                        buttonDeny.FlatAppearance.BorderSize = 0;

                        buttonModify.Click += (object sender, EventArgs e) =>
                        {
                            Panel panelPopup = new Panel()
                            {
                                BorderStyle = BorderStyle.FixedSingle,
                                BackColor = Color.White,
                                Width = Convert.ToInt32(control.Width * .5),
                                Height = Convert.ToInt32(control.Height * .5),
                                Location = new Point(Convert.ToInt32(control.Width * .25), Convert.ToInt32(control.Height * .20))
                            };
                            Label labelTitle = new Label()
                            {
                                Text = "Modify Meeting",
                                Width = 400,
                                Height = 50,
                                Font = new Font(Font.FontFamily, 24, FontStyle.Bold),
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .14), Convert.ToInt32(panelPopup.Height * .1))
                            };
                            DateTimePicker dateTimePickerStartDate = new DateTimePicker()
                            {
                                Format = DateTimePickerFormat.Custom,
                                CustomFormat = "MM/dd/yyyy hh:mm:ss tt",
                                Text = firstDocument[currentPos]["Date"].ToUniversalTime().ToString(),
                                Font = labelFont,
                                ShowUpDown = true,
                                Width = 145,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .28), Convert.ToInt32(panelPopup.Height * .4))
                            };
                            Label labelDuration = new Label()
                            {
                                Text = "Duration:",
                                Font = labelFont2,
                                Width = 67,
                                Height = 17,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .33), Convert.ToInt32(panelPopup.Height * .5))
                            };
                            Label label10Error = new Label()
                            {
                                Visible = false,
                                Text = "Cannot be\nWithin\nthe Next\n10 Minutes",
                                Width = 89,
                                Height = 76,
                                Font = labelFont4,
                                ForeColor = Color.Red,
                                TextAlign = ContentAlignment.TopCenter,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .01), Convert.ToInt32(panelPopup.Height * .33))
                            };
                            Label labelOccupiedError = new Label()
                            {
                                Visible = false,
                                Text = "This Time\nis Already\nTaken",
                                Width = 83,
                                Height = 57,
                                Font = labelFont4,
                                ForeColor = Color.Red,
                                TextAlign = ContentAlignment.TopCenter,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .73), Convert.ToInt32(panelPopup.Height * .38))
                            };
                            ComboBox comboBoxDuration = new ComboBox()
                            {
                                DropDownStyle = ComboBoxStyle.DropDownList,
                                SelectedItem = "10",
                                DataSource = new List<string>() { "10", "20", "30", "40", "60" },
                                Font = labelFont,
                                Width = 36,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .53), Convert.ToInt32(panelPopup.Height * .5))
                            };
                            Button buttonOk = new Button()
                            {
                                BackgroundImage = Properties.Resources.acceptButton,
                                BackgroundImageLayout = ImageLayout.Stretch,
                                FlatStyle = FlatStyle.Flat,
                                ForeColor = Color.Transparent,
                                Width = 43,
                                Height = 43,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .2), Convert.ToInt32(panelPopup.Height * .75))
                            };
                            buttonOk.FlatAppearance.MouseOverBackColor = Color.Transparent;
                            buttonOk.FlatAppearance.MouseDownBackColor = Color.Transparent;
                            buttonOk.FlatAppearance.BorderSize = 0;
                            Button buttonCancel = new Button()
                            {
                                BackgroundImage = Properties.Resources.denyButton,
                                BackgroundImageLayout = ImageLayout.Stretch,
                                FlatStyle = FlatStyle.Flat,
                                ForeColor = Color.Transparent,
                                Width = 43,
                                Height = 43,
                                Location = new Point(Convert.ToInt32(panelPopup.Width * .65), Convert.ToInt32(panelPopup.Height * .75))
                            };
                            buttonCancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
                            buttonCancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
                            buttonCancel.FlatAppearance.BorderSize = 0;
                            
                            buttonOk.Click += (object sender2, EventArgs e2) =>
                            {
                                if (dateTimePickerStartDate.Text != "" && DateTime.Now.AddMinutes(10) < Convert.ToDateTime(dateTimePickerStartDate.Text))
                                {
                                    label10Error.Visible = false;
                                    bool valid = true;
                                    DateTime startTime1 = Convert.ToDateTime(dateTimePickerStartDate.Text);
                                    DateTime endTime1 = Convert.ToDateTime(dateTimePickerStartDate.Text).AddMinutes(Convert.ToInt32(comboBoxDuration.Text));
                                    EventsResource.ListRequest request = new EventsResource.ListRequest(service, "primary");
                                    request.SingleEvents = true;
                                    request.TimeMin = startTime1;
                                    request.TimeMax = endTime1;
                                    Events events1 = request.Execute();
                                    if (events1.Items != null && events1.Items.Count > 0)
                                    {
                                        foreach (var eventItem in events1.Items)
                                        {
                                            if (eventItem.Start.DateTime >= startTime1 && eventItem.Start.DateTime <= endTime1)
                                            {
                                                valid = false;
                                            }
                                            else if (eventItem.End.DateTime >= startTime1 && eventItem.End.DateTime <= endTime1)
                                            {
                                                valid = false;
                                            }
                                        }
                                    }

                                    if (valid)
                                    {
                                        labelOccupiedError.Visible = false;
                                        string meetingName = firstDocument[currentPos]["Name"].AsString;
                                        DateTime startTime = Convert.ToDateTime(firstDocument[currentPos]["Date"].ToString().Replace("Z", ""));
                                        DateTime endTime = Convert.ToDateTime(firstDocument[currentPos]["EndTime"].ToString().Replace("Z", ""));
                                        string eventId = "";
                                        EventsResource.ListRequest request1 = new EventsResource.ListRequest(service, "primary");
                                        request1.SingleEvents = true;
                                        request1.TimeMin = startTime;
                                        request1.TimeMax = endTime;
                                        Events events = request1.Execute();
                                        if (events.Items != null && events.Items.Count > 0)
                                        {
                                            foreach (var eventItem in events.Items)
                                            {
                                                if (eventItem.Summary != null)
                                                {
                                                    if (eventItem.Summary.Contains(meetingName) && eventItem.Start.DateTime == startTime && eventItem.End.DateTime == endTime)
                                                    {
                                                        eventId = eventItem.Id;
                                                    }
                                                }
                                            }
                                        }
                                        if (eventId != "")
                                        {
                                            EventsResource.DeleteRequest request2 = new EventsResource.DeleteRequest(service, "primary", eventId);
                                            request2.Execute();
                                        }

                                        var filter = Builders<BsonDocument>.Filter.Eq("_id", firstDocument[currentPos]["_id"]);
                                        var update = Builders<BsonDocument>.Update.Set("Date", Convert.ToDateTime(dateTimePickerStartDate.Text).ToLocalTime());
                                        var update2 = Builders<BsonDocument>.Update.Set("EndTime", Convert.ToDateTime(dateTimePickerStartDate.Text).AddMinutes(Convert.ToInt32(comboBoxDuration.Text)).ToLocalTime());
                                        var update3 = Builders<BsonDocument>.Update.Set("Status", "modified");
                                        collection.UpdateOne(filter, update);
                                        collection.UpdateOne(filter, update2);
                                        collection.UpdateOne(filter, update3);

                                        panelPopup.Dispose();
                                        timerRun = true;
                                    } else
                                    {
                                        labelOccupiedError.Visible = true;
                                    }
                                }
                                else
                                {
                                    label10Error.Visible = true;
                                }
                            };
                            buttonCancel.Click += (object sender2, EventArgs e2) =>
                            {
                                panelPopup.Dispose();

                                var filter = Builders<BsonDocument>.Filter.Eq("_id", firstDocument[currentPos]["_id"]);
                                if (firstDocument[currentPos]["__v"] == 0)
                                {
                                    var update = Builders<BsonDocument>.Update.Set("__v", 1);
                                    collection.UpdateOne(filter, update);
                                }
                                else
                                {
                                    var update = Builders<BsonDocument>.Update.Set("__v", 0);
                                    collection.UpdateOne(filter, update);
                                }
                                timerRun = true;
                            };

                            control.Controls.Clear();
                            control.Controls.Add(panelPopup);
                            panelPopup.Controls.Add(labelTitle);
                            panelPopup.Controls.Add(dateTimePickerStartDate);
                            panelPopup.Controls.Add(labelDuration);
                            panelPopup.Controls.Add(label10Error);
                            panelPopup.Controls.Add(labelOccupiedError);
                            panelPopup.Controls.Add(comboBoxDuration);
                            panelPopup.Controls.Add(buttonOk);
                            panelPopup.Controls.Add(buttonCancel);
                        };
                        buttonDeny.Click += (object sender, EventArgs e) =>
                        {
                            string meetingName = firstDocument[currentPos]["Name"].AsString;
                            DateTime startTime = Convert.ToDateTime(firstDocument[currentPos]["Date"].ToString().Replace("Z", ""));
                            DateTime endTime = Convert.ToDateTime(firstDocument[currentPos]["EndTime"].ToString().Replace("Z", ""));
                            string eventId = "";
                            EventsResource.ListRequest request = new EventsResource.ListRequest(service, "primary");
                            request.SingleEvents = true;
                            Events events = request.Execute();
                            if (events.Items != null && events.Items.Count > 0)
                            {
                                foreach (var eventItem in events.Items)
                                {
                                    if (eventItem.Summary != null)
                                    {
                                        if (eventItem.Summary.Contains(meetingName) && eventItem.Start.DateTime == startTime && eventItem.End.DateTime == endTime)
                                        {
                                            eventId = eventItem.Id;
                                        }
                                    }
                                }
                            }
                            if (eventId != "")
                            {
                                EventsResource.DeleteRequest request1 = new EventsResource.DeleteRequest(service, "primary", eventId);
                                request1.Execute();
                            }

                            var filter = Builders<BsonDocument>.Filter.Eq("_id", firstDocument[currentPos]["_id"]);
                            var update = Builders<BsonDocument>.Update.Set("Status", "denied");
                            collection.UpdateOne(filter, update);

                            timerRun = true;
                        };

                        control.Controls.Add(panel);
                        panel.Controls.Add(labelName);
                        panel.Controls.Add(labelDate);
                        panel.Controls.Add(labelEndDate);
                        panel.Controls.Add(labelMessage);
                        panel.Controls.Add(labelUpcoming);
                        panel.Controls.Add(buttonModify);
                        panel.Controls.Add(buttonDeny);
                        if (color == Color.White)
                        {
                            color = ColorTranslator.FromHtml("#f9f9f9");
                        }
                        else
                        {
                            color = Color.White;
                        }
                    }
                    else
                    {
                        count++;
                    }
                }
            }

            oldDocument = firstDocument;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            run = false;
        }
    }
}