using Microsoft.JSInterop;

namespace PSC.Blazor.Components.Clippy
{
    /// <summary>
    /// Clippy Service
    /// </summary>
    public class ClippyService
    {
        /// <summary>
        /// The js
        /// </summary>
        private readonly IJSRuntime js;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClippyService"/> class.
        /// </summary>
        /// <param name="js">The js.</param>
        public ClippyService(IJSRuntime js)
        {
            this.js = js;
        }

        /// <summary>
        /// Animates the random.
        /// </summary>
        public async Task AnimateRandom()
        {
            await js.InvokeVoidAsync("bClippy.animateRandom");
        }

        /// <summary>
        /// Gestures at.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public async Task GestureAt(int x, int y)
        {
            await js.InvokeVoidAsync("bClippy.gestureAt", new object[] { x, y });
        }

        /// <summary>
        /// Gets the animations list.
        /// </summary>
        /// <returns></returns>
        public async Task<List<string>> GetAnimationsList()
        {
            var list = await js.InvokeAsync<List<string>>("bClippy.getAnimationsList");
            if (list != null)
                list.ForEach(i => Console.WriteLine(i));
            return list ?? new List<string>();
        }

        /// <summary>
        /// Hides this instance.
        /// </summary>
        public async Task Hide()
        {
            await js.InvokeVoidAsync("bClippy.hide");
        }

        /// <summary>
        /// Loads the specified agent name.
        /// </summary>
        /// <param name="agentName">Name of the agent.</param>
        public async Task Load(AgentName agentName = AgentName.Clippy)
        {
            await js.InvokeVoidAsync("bClippy.load", agentName.ToString());
        }
        /// <summary>
        /// Plays the animation.
        /// </summary>
        /// <param name="animation">The animation.</param>
        public async Task PlayAnimation(ClippyAnimations animation)
        {
            await js.InvokeVoidAsync("bClippy.play", Enum.GetName(typeof(ClippyAnimations), animation));
        }

        /// <summary>
        /// Speaks the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        public async Task Speak(string text)
        {
            await js.InvokeVoidAsync("bClippy.speak", text);
        }
        /// <summary>
        /// Stops this instance.
        /// </summary>
        public async Task Stop()
        {
            await js.InvokeVoidAsync("bClippy.stop");
        }

        /// <summary>
        /// Stops the current.
        /// </summary>
        public async Task StopCurrent()
        {
            await js.InvokeVoidAsync("bClippy.stopCurrent");
        }
    }
}