## Readme
What is this?

A SignalR driven chat app.  This one exposes a controller that will listen on the local port and then allow JSON content through a `POST`.  

Send any content to the URL and it shows up in the Chat box.  From any pc!

### How to use

Publish as a Docker Container
From any system in your network, run commands like those shown in .\scratch.ps1
See these messages appear in your Chat app! 

### To Do

* Restyle the notifications used
* Add 'ComputerName' to MessageContent.ps1
* * Add this to chat.js
* Add Inserted Timestamp when a new message comes in

* Test with juicy content!
* Get publishing to docker container working on custom port (6001?)


### To Done

* Can accept Post ✔
* Make Listener add new bootstrap notification ✔
* Convert listener to trigger JS function ✔
* Restyle ✔
* Expose ability to use any of the 8 built in boot strap color styles ✔
