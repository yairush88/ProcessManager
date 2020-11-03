# ProcessManager
Windows processes service

Client (like Postman) can invoke commands against a REST API which in turn invokes a WCF service

The WCF services is configured to be a singlton and keeps it's state (the list of processes) bewtween service calls.
The feature that need to be completed is updating the list of process inside the WCF every 10 seconds (without using a timer).
