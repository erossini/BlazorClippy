# Clippy for Blazor
Do you remember Clippy? If the answer is no, please go away!

This is a component for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/). The component is built with .NET6.


Some useful link:
- Source code available on [GitHub](https://github.com/erossini/BlazorClippy)
- Demo website [here](https://clippy.puresourcecode.com/)
- More info about this component on [PureSourceCode.com](https://www.puresourcecode.com/dotnet/blazor/clippy-blazor-component/)
- Support and forum [here](https://www.puresourcecode.com/forum/clippy/)

Clippy is an Office assistant that helped users when they were using any of the Microsoft Office applications. 
Clippy's role was to communicate with users and give corresponding actions. The original name was Clippit, but it was later nicknamed "Clippy".

The name came as a result of its resemblance to a paperclip. It was one of the notable assistants that helped users when using any MS applications. 
Unfortunately, Clippy got some negative feedback from certain users that led to its removal in later Microsoft Office applications versions.

Clippy is a paperclip that was created by Kevan J. Atterberry. It was made to create a social interface to make it easier for people to understand the computer.

Generally, the idea behind Clippy was to assist users in understanding how to use the operating system. Thereby, users could access certain features on Microsoft programs and applications quickly.

The Clippy used a series of Bayesian algorithms to determine the users' needs. In a big way, it also helped in typing cues, autoformat, and other features. However, people later complained that it was intrusive ad annoying, which led to its removal.

## Add Clippy library
In your Blazor project, add the Clippy package from [Nuget](https://www.nuget.org/packages/PSC.Blazor.Components.Clippy/). 
In the `Import.razor` add the reference to the package

```csharp
@using PSC.Blazor.Components.Clippy
```

Then, you have to add the **Clippy** service to your project. In your `Program.cs`, add the following line

```csharp
using PSC.Blazor.Components.Clippy
...
builder.Services.AddScoped<ClippyService>();
```

before

```csharp
await builder.Build().RunAsync();
```

### Add scripts
Now, you have to add the CSS style and the scripts for Clippy. Go to your `index.html` under `wwwroot`. In the `HEAD` section, add the folloing line

```html
<link rel="stylesheet" type="text/css" href="_content/PSC.Blazor.Components.Clippy/clippy.css" media="all">
```

Then, at the bottom of the page before closing the tag `BODY` add the following scripts:

```html
<script src="_content/PSC.Blazor.Components.Clippy/clippy.min.js"></script>
<script src="_content/PSC.Blazor.Components.Clippy/clippyInterop.js"></script>
```

If your application doesn't have `jQuery`, you have to add this line

```html
<script src="_content/PSC.Blazor.Components.Clippy/jquery.slim.min.js"></script>
```

## Use Clippy
To use Clippy in a Razor page, inject `ClippyService` in the page adding this code in the `@code` section

```csharp
[Inject] 
public ClippyService clippy { get; set; }
```

or at the top of the page

```csharp
@inject ClippyService clippy
```

Now, you can use `clippy` service in the page. To load an agent, use this code

```csharp
await clippy.Load(agentName);
```

`agentName` is one of the following from the enum `AgentName`

- Bonzi
- Clippy (default)
- F1
- Genie
- Genius
- Links
- Merlin
- Peedy
- Rocky
- Rover

![Clippy agents](https://user-images.githubusercontent.com/9497415/173025842-4b6b42e7-4dec-45ef-a3e6-e7ddfb107ce2.png)

## Clippy functions

| Name              | Parameters                 | Return       | Description                                      |
|-------------------|----------------------------|--------------|--------------------------------------------------|
| AnimateRandom     |                            |              | Play an randon animation for the list            |
| GestureAt         | int x, int y               |              | The agent points in the direction of the x and y |
| GetAnimationsList |                            | List&lt;string> | List of animation for an agent                   |
| Hide              |                            |              | Hide and dispose the agent                       |
| Load              | AgentName agentName        |              | Load an agent. By default the agent is `Clippy`. Select another agent using the enum `AgentName` |
| PlayAnimation     | ClippyAnimations animation |              | Play one of the animation for the agent. Choose from the enum `ClippyAnimations`. See below the list of available animations |
| Speak             | string text                |              | Show the `text` in the baloon                    | 
| Stop              |                            |              | Stop all actions in the queue and go back to idle mode |
| StopCurrent       |                            |              | Stop the current action in the queue             |

## Animation list

- Congratulate
- LookRight
- SendMail
- Thinking
- Explain
- IdleRopePile
- IdleAtom
- Print
- Hide
- GetAttention
- Save
- GetTechy
- GestureUp
- Idle1_1
- Processing
- Alert
- LookUpRight
- IdleSideToSide
- GoodBye
- LookLeft
- IdleHeadScratch
- LookUpLeft
- CheckingSomething
- Hearing_1
- GetWizardy
- IdleFingerTap
- GestureLeft
- Wave
- GestureRight
- Writing
- IdleSnooze
- LookDownRight
- GetArtsy
- Show
- LookDown
- Searching
- EmptyTrash
- Greeting
- LookUp
- GestureDown
- RestPose
- IdleEyeBrowRaise
- LookDownLeft

## Example

```csharp
await clippy.Load(AgentName.Clippy);
await clippy.PlayAnimation(ClippyAnimations.GetAttention);
await clippy.Speak("Hello Blazor! Do you like it?");
await clippy.Speak("I can help your users. You know I can do that :)");
await clippy.PlayAnimation(ClippyAnimations.CheckingSomething);
await clippy.Speak("I helped whole generation of people with PC :)");
await clippy.PlayAnimation(ClippyAnimations.GoodBye);
```

## Screenshot demo
The demo application shows all the functionalities offer from the component. Select an agent from the list and then click *Load*.

![Screenshot demo](https://user-images.githubusercontent.com/9497415/173026049-e29bd8d2-689f-4830-8e48-65447b2bd202.png)

Here the list of agents available.

![Screenshot demo](https://user-images.githubusercontent.com/9497415/173026144-73c5594e-c85f-4365-aa53-442c9cede671.png)

---
    
## Other Blazor components

| Component name | Forum | Description |
|---|---|---|
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | DataTable component for Blazor WebAssembly and Blazor Server |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/markdown-editor-for-blazor/) |  This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Browser Detect for Blazor](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/) | Browser detect for Blazor WebAssembly and Blazor Server |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/code-snippet-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | Add a button to copy text in the clipbord | 
| SVG Icons and flags for Blazor | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| [Modal dialog for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) |  Simple Modal Dialog for Blazor WebAssembly |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) |  A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://www.puresourcecode.com/forum/forum/quill-for-blazor/) |  Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/segments-for-blazor/) |  This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/tabs-for-blazor/) |  This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [WorldMap for Blazor]() | [Forum](https://www.puresourcecode.com/forum/worldmap-for-blazor/) | Show world maps with your data |

## More examples and documentation
*   [Write a reusable Blazor component](https://www.puresourcecode.com/dotnet/blazor/write-a-reusable-blazor-component/)
*   [Getting Started With C# And Blazor](https://www.puresourcecode.com/dotnet/net-core/getting-started-with-c-and-blazor/)
*   [Setting Up A Blazor WebAssembly Application](https://www.puresourcecode.com/dotnet/blazor/setting-up-a-blazor-webassembly-application/)
*   [Working With Blazor Component Model](https://www.puresourcecode.com/dotnet/blazor/working-with-blazors-component-model/)
*   [Secure Blazor WebAssembly With IdentityServer4](https://www.puresourcecode.com/dotnet/blazor/secure-blazor-webassembly-with-identityserver4/)
*   [Blazor Using HttpClient With Authentication](https://www.puresourcecode.com/dotnet/blazor/blazor-using-httpclient-with-authentication/)
*   [InputSelect component for enumerations in Blazor](https://www.puresourcecode.com/dotnet/blazor/inputselect-component-for-enumerations-in-blazor/)
*   [Use LocalStorage with Blazor WebAssembly](https://www.puresourcecode.com/dotnet/blazor/use-localstorage-with-blazor-webassembly/)
*   [Modal Dialog component for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/)
*   [Create Tooltip component for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-tooltip-component-for-blazor/)
*   [Consume ASP.NET Core Razor components from Razor class libraries | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-5.0&tabs=visual-studio)
