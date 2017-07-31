# ASP.MVC Response Flush

* **NoFlush** - Usual flow with __Layout.cshtml_ including &lt;head&gt; and &lt;body&gt;. ViewResult returned at the end of the lifecycle
* **SyncFlush** - Synchronously flush __Head.cshtml_ to the client before continues with __Layout.cshtml_
* **AsyncFlush** - Asynchronously flush __Head.cshtml_ to the client continuing with __Layout.cshtml_ <sub><sup>(supported on ASP.NET 4.5+)</sub></sub>

All three approaches wait 1 second before return the final response.
