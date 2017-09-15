using System;
using System.Reflection;
using Terraria;
using TerrariaApi.Server;

namespace TShockPluginTemplate
{
    /// <summary>
    /// Represents the TShockPluginTemplate plugin.
    /// </summary>
    [ApiVersion(2, 1)]
    public class TShockPluginTemplatePlugin : TerrariaPlugin
    {
        /// <inheritdoc />
        public TShockPluginTemplatePlugin(Main game) : base(game)
        {
        }

        /// <inheritdoc />
        public override string Author => "Plugin author";

        /// <inheritdoc />
        public override string Description => "Plugin description";
        
        /// <inheritdoc />
        public override string Name => "Plugin name";

        /// <inheritdoc />
        public override Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                
            }
            
            base.Dispose(disposing);
        }

        /// <inheritdoc />
        public override void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}