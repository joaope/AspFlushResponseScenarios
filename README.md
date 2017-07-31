# ASP.MVC Response Flush

* **[NoFlush](https://github.com/joaope/AspFlushResponseScenarios/blob/master/NoFlush/Controllers/HomeController.cs#L14)** - Usual flow with __Layout.cshtml_ including &lt;head&gt; and &lt;body&gt;. ViewResult returned at the end of the lifecycle
* **[SyncFlush](https://github.com/joaope/AspFlushResponseScenarios/blob/master/SyncFlush/Controllers/HomeController.cs#L14)** - Synchronously flush __Head.cshtml_ to the client before continues with __Layout.cshtml_
* **[AsyncFlush](https://github.com/joaope/AspFlushResponseScenarios/blob/master/AsyncFlush/Controllers/HomeController.cs#L18)** - Asynchronously flush __Head.cshtml_ to the client continuing with __Layout.cshtml_ <sub><sup>(supported on ASP.NET 4.5+)</sub></sub>

All three approaches wait 1 second before return the final response.
