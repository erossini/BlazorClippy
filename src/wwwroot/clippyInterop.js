class ClippyForBlazor {
    constructor() {
    }

    load(agentName) {
        if (window.clippyAgent != undefined) {
            window.clippyAgent.hide();
            window.clippyAgent = null;
        }

        clippy.load(agentName, agent => {
            window.clippyAgent = agent;
            agent.show();
        });
    }

    animateRandom() {
        if (window.clippyAgent != undefined) {
            window.clippyAgent.animate();
        }
    }

    play(animation) {
        if (window.clippyAgent != undefined) {
            window.clippyAgent.play(animation);
        }
    }

    speak(text) {
        if (window.clippyAgent != undefined) {
            window.clippyAgent.speak(text);
        }
    }

    getAnimationsList() {
        if (window.clippyAgent != undefined) {
            return window.clippyAgent.animations();
        }
        return [];
    }

    gestureAt(x, y) {
        if (window.clippyAgent != undefined) {
            window.clippyAgent.gestureAt(x, y);
        }
    }

    hide() {
        if (window.clippyAgent != undefined) {
            window.clippyAgent.hide();
        }
    }

    stopCurrent() {
        if (window.clippyAgent != undefined) {
            window.clippyAgent.stopCurrent();
        }
    }

    stop() {
        if (window.clippyAgent != undefined) {
            window.clippyAgent.stop();
        }
    }
}

window.bClippy = new ClippyForBlazor()