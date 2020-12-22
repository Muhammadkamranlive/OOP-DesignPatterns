using static System.Console;
using System.Collections.Generic;

namespace AdapterDependencyInjection
{
    public class Editor
    {
        private IEnumerable<Button> buttons;

        public Editor(IEnumerable<Button> buttons)
        {
            this.buttons = buttons;
        }

        public IEnumerable<Button> Buttons => buttons;

        public void ClickAll()
        {
            foreach (var btn in buttons)
                btn.Click();
        }
    }
}
