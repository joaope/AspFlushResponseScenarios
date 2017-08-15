# ASP.MVC Response Flush

* **[NoFlush](https://github.com/joaope/AspFlushResponseScenarios/blob/a87a3f562a2c834f8dcfeca6068fcc43a3dc579b/NoFlush/Controllers/HomeController.cs#L14)** - Usual flow with __Layout.cshtml_ including &lt;head&gt; and &lt;body&gt;. ViewResult returned at the end of the lifecycle
* **[SyncFlush](https://github.com/joaope/AspFlushResponseScenarios/blob/a87a3f562a2c834f8dcfeca6068fcc43a3dc579b/SyncFlush/Controllers/HomeController.cs#L13)** - Synchronously flush __Head.cshtml_ to the client before continues with __Layout.cshtml_
* **[AsyncFlush](https://github.com/joaope/AspFlushResponseScenarios/blob/a87a3f562a2c834f8dcfeca6068fcc43a3dc579b/AsyncFlush/Controllers/HomeController.cs#L14)** - Asynchronously flush __Head.cshtml_ to the client continuing with __Layout.cshtml_ <sub><sup>(supported on ASP.NET 4.5+)</sub></sub>

All three approaches wait 1 second before return the final response.
