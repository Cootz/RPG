using System;
using System.Collections.Generic;
using System.Text;

namespace rpg.Game.UI
{
    public static class SceneManager
    {
        private static Stack<Scene> navigationStack = new Stack<Scene>();

        public static void Push(Scene scene) => navigationStack.Push(scene);

        public static void Pop() => navigationStack.Pop();
    }
}
