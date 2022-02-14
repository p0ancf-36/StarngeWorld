using SFML.Graphics;
using SFML.Window;
using System.Collections.Generic;

namespace StrangeWorld.Client
{
	public class Window : RenderWindow
	{
		public Window(VideoMode mode, string title) : base(mode, title)
		{

		}

		private List<Drawable> _drawbles;

		public void AddDrawble(Drawable drawable)
		{
			_drawbles.Add(drawable);
		}
		public void Update()
		{
			DispatchEvents();
			Clear();

			foreach (var drawble in _drawbles)
			{
				Draw(drawble);
			}

			Display();
			_drawbles.Clear();
		}
	}
}