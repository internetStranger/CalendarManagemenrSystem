# CalendarManagemenrSystem

The project is a calendar system including functions such as adding and editing events that the user creates.
The current project uses the database at EKU to access created events.
The current version has a few minor errors:
   i.) there is no event date/time verification - ie.) multiple events can be created for the same date and time
   ii.) error message display - the incorrect error message is displayed when logging in with incorrect credentials.

The project allows for the creating, viewing, editing, and deleting of events on the user’s calendar.

The project also includes a log-in system which will only allow users with the right credentials access to their specific calendar.

When viewing an event the title, start-time, end-time, and a description will be displayed.
Events can be found by clicking on the date an event is set for or by searching for events in every month.

Attempting to delete an event will open a second window to verify the user is sure they want to delete the event

Adding/creating an event takes the current date that the user has selected on the calendar, and a second window for the user to fill will open.
A title, start-time, and end-time are all required for the event to be created. meanwhile the description is entirely optional.

To edit an existing click on the event that you wish to change. In the center panel will display all the relevant information.
From there makes changes to the title, start-time, end-time, and description as you see fit. If you wish to discard the changes, click the cancel button, otherwise click save.
*NOTE that the changes will be permanent after clicking save*

Once you are done using your calendar you can log out by clicking the "Log Out" button. It is for the privacy and security of the user.
