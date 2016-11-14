﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace client
{
    public class Map
    {
        public string Location;
        public List<Layer> Layer;
        public Vector2 TileDimensions;
        public Map()
        {
            Layer = new List<Layer>();
            TileDimensions = Vector2.Zero;
        }
        public void LoadContent()
        {
            foreach (Layer l in Layer)
                l.LoadContent(TileDimensions);
        }
        public void UnloadContent()
        {
            foreach (Layer l in Layer)
                l.UnloadContent();
        }
        public void Update(GameTime gameTime)
        {
            foreach (Layer l in Layer)
                l.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Layer l in Layer)
                l.Draw(spriteBatch);
        }
    }
}