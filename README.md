# CHC College Counseling Scheduling App

During my Intro to Engineering class in my sophomore year at CHC, we had the opportunity to take up several projects around the school. The project [Tripp](https://github.com/PureTrippH/Dolphin-Office-Booking-App) and myself decided to take on was an appointment scheduling app for the College Counseling Office. The office originally requested the app because of the overwhelming inefficiency when it came to using email to schedule appointments with the student body.

## Counselor's Component (Windows Application)

I developed the C# Windows Forms app that allowed the counseling office to log in with their Google account and check a list of student appointment requests fetched from MongoDB. These appointment requests included time, date, duration, student, and reason for meeting. They could then accept, reject, or modify the requests based on their availability. Accepting the request would notify the student via email and text, as well as schedule the meeting on the counselor's Google Calendar. Both rejecting or amending the request would notify the student with an attached message. This allowed for an easy and effiecient dialogue between counselor and student.

## Student Component (Web App)

Tripp developed the website end of the project, where students could log in by using their CHC email and request a meeting. Requesting a meeting was as simple as entering a time, date, duration, reason, and counselor to meet with. Meetings already scheduled on the counselor's calendars were displayed on the website to prevent double booking. The website integrated key features mentioned above such as email and text notifications, as well as back-and-forth communication in modifying appointment details. 
