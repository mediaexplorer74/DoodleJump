// Type: mrGame.Game1
// Assembly: DoodleJump, Version=1.8.10.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
//using Microsoft.Phone.Shell;
//using Microsoft.Phone.Tasks;
//using Microsoft.Xna.Framework.GamerServices;


//#nullable disable
namespace mrGame
{
    public class Game1 : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        public BasicEffect basicEffect;
        public VertexPositionColorTexture[] vertices;
        public RasterizerState rasterizerState;
        public Rectangle clipRectangle;
        public Texture2D tex;
        public Texture2D loadingScreen;
        private BlendState blendState1;
        private mrGame.MrGame mrgame;
        private KeyboardState oldState;
        private ButtonState backButtonState;
        private int firstUpdate;
        private bool drawCalled;

        public Game1()
        {
          this.graphics = new GraphicsDeviceManager((Game) this);
          this.graphics.IsFullScreen = true;
          this.graphics.PreferredBackBufferFormat = SurfaceFormat.Color;
          this.graphics.PreferredDepthStencilFormat = DepthFormat.None;
          this.graphics.SupportedOrientations = mrGame.MrGame.mrp_getSupportedOrientations();
          this.Window.OrientationChanged += new EventHandler<EventArgs>(this.Window_OrientationChanged);
          this.Content.RootDirectory = "Content";
          this.IsFixedTimeStep = false;
          this.mrgame = new mrGame.MrGame();
          this.mrgame.xnagame = this;
          this.mrgame.p_startTimeMS = DateTime.Now.Ticks;
          this.mrgame.mrp_preinits();

          //PhoneApplicationService.Current.ApplicationIdleDetectionMode = (IdleDetectionMode) 0;
          //PhoneApplicationService.Current.Activated += new EventHandler<ActivatedEventArgs>(this.On_Activated);
          //PhoneApplicationService.Current.Deactivated += new EventHandler<DeactivatedEventArgs>(this.On_Deactivated);
          //PhoneApplicationService.Current.Closing += new EventHandler<ClosingEventArgs>(this.On_Closing);
          //PhoneApplicationService.Current.Launching += new EventHandler<LaunchingEventArgs>(this.On_Launching);
        }

        
        private void On_Launching(object sender, EventArgs args)
        {
        }

        private void On_Closing(object sender, EventArgs args)
        {
        }
        

        private void On_Deactivated(object sender, EventArgs args)
        {
          if (this.mrgame == null || this.mrgame.runko_state <= 0)
            return;
          this.mrgame.p_xna_stopAccelerationSensor_withState();
          this.mrgame.hideNotify();
        }

        private void On_Activated(object sender, EventArgs args)
        {
          this.SetBufferSize();
          if (this.mrgame == null || this.mrgame.runko_state <= 0)
            return;
          this.mrgame.p_xna_startAccelerationSensor_withState();
          this.mrgame.showNotify();
        }

        private void Window_OrientationChanged(object sender, EventArgs e) => this.SetBufferSize();

        private void SetBufferSize()
        {
          if ((this.graphics.SupportedOrientations ^ DisplayOrientation.Portrait) == DisplayOrientation.Default)
          {
            this.graphics.PreferredBackBufferWidth = this.graphics.GraphicsDevice.DisplayMode.Width;
            this.graphics.PreferredBackBufferHeight = this.graphics.GraphicsDevice.DisplayMode.Height;
          }
          else if ((this.graphics.SupportedOrientations & DisplayOrientation.Portrait) != DisplayOrientation.Default)
          {
            if (this.Window.CurrentOrientation == DisplayOrientation.Portrait)
            {
              this.graphics.PreferredBackBufferWidth = this.graphics.GraphicsDevice.DisplayMode.Width;
              this.graphics.PreferredBackBufferHeight = this.graphics.GraphicsDevice.DisplayMode.Height;
            }
            else
            {
              this.graphics.PreferredBackBufferWidth = this.graphics.GraphicsDevice.DisplayMode.Height;
              this.graphics.PreferredBackBufferHeight = this.graphics.GraphicsDevice.DisplayMode.Width;
            }
          }
          else
          {
            this.graphics.PreferredBackBufferWidth = this.graphics.GraphicsDevice.DisplayMode.Height;
            this.graphics.PreferredBackBufferHeight = this.graphics.GraphicsDevice.DisplayMode.Width;
          }
          this.graphics.ApplyChanges();
          int preferredBackBufferWidth = this.graphics.PreferredBackBufferWidth;
          int backBufferHeight = this.graphics.PreferredBackBufferHeight;
          this.basicEffect.Projection = Matrix.CreateOrthographicOffCenter(0.5f, (float) preferredBackBufferWidth + 0.5f, (float) backBufferHeight + 0.5f, 0.5f, 0.0f, 1f);
          if (this.mrgame == null)
            return;
          this.mrgame.mrp_sizeChanged(preferredBackBufferWidth, backBufferHeight);
        }

        protected override void OnActivated(object sender, EventArgs args)
        {
          base.OnActivated(sender, args);
        }

        protected override void OnDeactivated(object sender, EventArgs args)
        {
          base.OnDeactivated(sender, args);
        }

        protected override void Initialize()
        {
          this.basicEffect = new BasicEffect(this.graphics.GraphicsDevice);
          this.blendState1 = new BlendState();
          this.blendState1.AlphaBlendFunction = this.blendState1.ColorBlendFunction = BlendFunction.Add;
          this.blendState1.AlphaDestinationBlend = this.blendState1.ColorDestinationBlend = Blend.InverseSourceAlpha;
          this.blendState1.AlphaSourceBlend = this.blendState1.ColorSourceBlend = Blend.One;
          this.basicEffect.GraphicsDevice.BlendState = this.blendState1;
          this.basicEffect.GraphicsDevice.SamplerStates[0] = SamplerState.LinearClamp;
          this.basicEffect.TextureEnabled = true;
          this.basicEffect.VertexColorEnabled = true;
          this.vertices = new VertexPositionColorTexture[5];
          this.vertices[0] = new VertexPositionColorTexture(new Vector3(0.0f, 0.0f, 0.0f), new Color(1f, 1f, 1f), new Vector2(0.0f, 0.0f));
          this.vertices[1] = new VertexPositionColorTexture(new Vector3(100f, 0.0f, 0.0f), new Color(1f, 1f, 1f), new Vector2(1f, 0.0f));
          this.vertices[2] = new VertexPositionColorTexture(new Vector3(0.0f, 100f, 0.0f), new Color(1f, 1f, 1f), new Vector2(0.0f, 1f));
          this.vertices[3] = new VertexPositionColorTexture(new Vector3(100f, 100f, 0.0f), new Color(1f, 1f, 1f), new Vector2(1f, 1f));
          this.vertices[4] = new VertexPositionColorTexture(new Vector3(0.0f, 0.0f, 0.0f), new Color(1f, 1f, 1f), new Vector2(0.0f, 0.0f));
          if (this.Window.CurrentOrientation == DisplayOrientation.Portrait && (this.graphics.SupportedOrientations & DisplayOrientation.Portrait) != DisplayOrientation.Default)
          {
            this.graphics.PreferredBackBufferWidth = this.graphics.GraphicsDevice.DisplayMode.Width;
            this.graphics.PreferredBackBufferHeight = this.graphics.GraphicsDevice.DisplayMode.Height;
          }
          else
          {
            this.graphics.PreferredBackBufferWidth = this.graphics.GraphicsDevice.DisplayMode.Height;
            this.graphics.PreferredBackBufferHeight = this.graphics.GraphicsDevice.DisplayMode.Width;
          }
          this.graphics.ApplyChanges();
          int preferredBackBufferWidth = this.graphics.PreferredBackBufferWidth;
          int backBufferHeight = this.graphics.PreferredBackBufferHeight;
          this.basicEffect.Projection = Matrix.CreateOrthographicOffCenter(0.5f, (float) preferredBackBufferWidth + 0.5f, (float) backBufferHeight + 0.5f, 0.5f, 0.0f, 1f);
          this.mrgame.mrp_initSize(preferredBackBufferWidth, backBufferHeight);
          this.rasterizerState = new RasterizerState();
          this.rasterizerState.ScissorTestEnable = true;
          this.rasterizerState.CullMode = CullMode.None;
          this.graphics.GraphicsDevice.RasterizerState = this.rasterizerState;
          this.clipRectangle = new Rectangle(0, 0, this.graphics.GraphicsDevice.PresentationParameters.BackBufferWidth, this.graphics.GraphicsDevice.PresentationParameters.BackBufferHeight);
          this.oldState = Keyboard.GetState();
          this.backButtonState = GamePad.GetState(PlayerIndex.One).Buttons.Back;
          base.Initialize();
        }

        protected override void LoadContent()
        {
          this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
          this.loadingScreen = this.Content.Load<Texture2D>("loading");
          this.tex = new Texture2D(this.GraphicsDevice, 1, 1);
          this.tex.SetData<uint>(new uint[1]{ uint.MaxValue });
          this.GraphicsDevice.Textures[0] = (Texture) this.tex;
        }

        protected override void UnloadContent() => this.tex.Dispose();

        protected override void BeginRun()
        {
          this.firstUpdate = 2;
          base.BeginRun();
        }

        protected override void Update(GameTime gameTime)
        {
          if (!this.IsActive)
          {
            //Thread.Sleep(500);
          }
          else
          {
            if (this.mrgame.p_exitrunko)
              this.Exit();
            ButtonState back = GamePad.GetState(PlayerIndex.One).Buttons.Back;
            if (back == ButtonState.Pressed && this.backButtonState == ButtonState.Released)
              this.mrgame.mrp_keyPressed(0);
            else if (back == ButtonState.Released && this.backButtonState == ButtonState.Pressed)
              this.mrgame.mrp_keyReleased(0);
            this.backButtonState = back;
            KeyboardState state = Keyboard.GetState();
            Keys[] keysArray = new Keys[7]
            {
              Keys.Back,
              Keys.Up,
              Keys.Down,
              Keys.Left,
              Keys.Right,
              Keys.Enter,
              Keys.Space
            };
            for (int key = 0; key < keysArray.Length; ++key)
            {
              if (this.oldState.IsKeyUp(keysArray[key]) && state.IsKeyDown(keysArray[key]))
                this.mrgame.mrp_keyPressed(key);
              else if (this.oldState.IsKeyDown(keysArray[key]) && state.IsKeyUp(keysArray[key]))
                this.mrgame.mrp_keyReleased(key);
            }
            this.oldState = state;
            foreach (TouchLocation touchLocation in TouchPanel.GetState())
            {
              if (touchLocation.State == TouchLocationState.Pressed)
                this.mrgame.mrp_multitouch_create(touchLocation.Id, 
                    (long) gameTime.TotalGameTime.TotalMilliseconds, (int) touchLocation.Position.X, (int) touchLocation.Position.Y);
              else if (touchLocation.State == TouchLocationState.Moved)
                this.mrgame.mrp_multitouch_move(touchLocation.Id, (long) gameTime.TotalGameTime.TotalMilliseconds, (int) touchLocation.Position.X, (int) touchLocation.Position.Y);
              else if (touchLocation.State == TouchLocationState.Released)
                this.mrgame.mrp_multitouch_release(touchLocation.Id, (long) gameTime.TotalGameTime.TotalMilliseconds);
            }
            if (this.drawCalled)
            {
              this.drawCalled = false;
              if (this.firstUpdate > 0)
              {
                --this.firstUpdate;
                if (this.firstUpdate == 0)
                {
                  this.loadingScreen.Dispose();
                  this.loadingScreen = (Texture2D) null;
                }
              }
              this.mrgame.mrp_runkoMain();
              if (!this.mrgame.repaintScreen)
              {
                this.SuppressDraw();
                this.drawCalled = true;
              }
            }
            try
            {
              base.Update(gameTime);
            }
            catch (Exception ex)
            {
              this.mrgame.p_xbla_HandleUpdateRequired();
            }
          }
        }

        protected override void Draw(GameTime gameTime)
        {
          this.drawCalled = true;
          if (this.loadingScreen != null)
          {
            this.spriteBatch.Begin();
            if (this.graphics.GraphicsDevice.PresentationParameters.BackBufferWidth < this.graphics.GraphicsDevice.PresentationParameters.BackBufferHeight)
            {
              this.spriteBatch.Draw(this.loadingScreen, Vector2.Zero, Color.White);
            }
            else
            {
              float rotation = 4.712389f;
              float scale = 1f;
              float layerDepth = 0.0f;
              Vector2 origin = new Vector2((float) this.loadingScreen.Width, 0.0f);
              this.spriteBatch.Draw(this.loadingScreen, Vector2.Zero, new Rectangle?(), Color.White, rotation, origin, scale, SpriteEffects.None, layerDepth);
            }
            this.spriteBatch.End();
          }
          else if (!this.mrgame.p_xbla_systemMessageIsVisible())
          {
            if (this.mrgame.p_isUpdateAvailable())
            {
              this.mrgame.p_ShowUpdateAvailableDialog();
            }
            else
            {
              if (!this.mrgame.repaintScreen)
                return;
              this.GraphicsDevice.BlendState = this.blendState1;
              this.GraphicsDevice.SamplerStates[0] = SamplerState.LinearClamp;
              this.GraphicsDevice.RasterizerState = this.rasterizerState;
              this.GraphicsDevice.Textures[0] = (Texture) this.tex;
              this.clipRectangle.X = 0;
              this.clipRectangle.Y = 0;
              this.clipRectangle.Width = this.graphics.GraphicsDevice.PresentationParameters.BackBufferWidth;
              this.clipRectangle.Height = this.graphics.GraphicsDevice.PresentationParameters.BackBufferHeight;
              this.GraphicsDevice.ScissorRectangle = this.clipRectangle;
              foreach (EffectPass pass in this.basicEffect.CurrentTechnique.Passes)
              {
                pass.Apply();
                this.mrgame.p_realPaint();
              }
              this.mrgame.repaintScreen = false;
            }
          }
          base.Draw(gameTime);
        }

        public void gfx_setClip(int x, int y, int w, int h)
        {
          this.graphics.GraphicsDevice.ScissorRectangle = Rectangle.Intersect(new Rectangle(0, 0, this.graphics.GraphicsDevice.PresentationParameters.BackBufferWidth, this.graphics.GraphicsDevice.PresentationParameters.BackBufferHeight), new Rectangle(x, y, w, h));
        }

        public void openBrowser(string url)
        {
                //RnD
          //new WebBrowserTask() { URL = url }.Show();
        }
      }
    }
