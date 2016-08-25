Created by The New Age Soldier - http://newagesoldier.com

These programs were built using the memory.dll program found at https://newagesoldier.com/memory-hacker/

When creating a new trainer project with the memory.dll you need to have the program run as admin.

You can do OneClick security with a code signing certificate, or...

In Visual Studio right click Project > Add New Item > "Application Manifest File".

Change <requestedExecutionLevel> element to:

<requestedExecutionLevel level="requireAdministrator" uiAccess="false" />