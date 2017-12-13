using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlimDX.Windows;
using System.Windows.Forms;
using SlimDX;
using SlimDX.D3DCompiler;
using SlimDX.Direct3D11;
using SlimDX.DXGI;
using SlimDX.Windows;
using Device = SlimDX.Direct3D11.Device;
using Resource = SlimDX.Direct3D11.Resource;
namespace Spielesammlung.Vanguards
{
    class Vanguards
    {
        Device device;
        SwapChain swapChain;
        ShaderSignature inputSignature;
        VertexShader vertexShader;
        PixelShader pixelShader;
        RenderForm gWindow = new RenderForm("Vanguard Test");

        

        public Vanguards()
        {
            StartWindow();
        }


        public void StartWindow()
        {
            

            var description = new SwapChainDescription()
            {
                BufferCount = 2,
                Usage = Usage.RenderTargetOutput,
                OutputHandle = form.Handle,
                IsWindowed = true,
                ModeDescription = new ModeDescription(0, 0, new Rational(60, 1), Format.R8G8B8A8_UNorm),
                SampleDescription = new SampleDescription(1, 0),
                Flags = SwapChainFlags.AllowModeSwitch,
                SwapEffect = SwapEffect.Discard
            };

            Device.CreateWithSwapChain(DriverType.Hardware, DeviceCreationFlags.Debug, description, out device, out swapChain);
            RenderTargetView renderTarget;
            using (var resource = Resource.FromSwapChain<Texture2D>(swapChain, 0))
                renderTarget = new RenderTargetView(device, resource);
            var context = device.ImmediateContext;
            var viewport = new Viewport(0.0f, 0.0f, gWindow.ClientSize.Width, gWindow.ClientSize.Height);
            context.OutputMerger.SetTargets(renderTarget);
            context.Rasterizer.SetViewports(viewport);
            using (var factory = swapChain.GetParent<Factory>())
                factory.SetWindowAssociation(gWindow.Handle, WindowAssociationFlags.IgnoreAltEnter);

            // handle alt+enter ourselves
            gWindow.KeyDown += (o, e) =>
            {
                if (e.Alt && e.KeyCode == Keys.Enter)
                    swapChain.IsFullScreen = !swapChain.IsFullScreen;
            };
            MessagePump.Run(gWindow, () =>
            {
                // clear the render target to a soothing blue
                context.ClearRenderTargetView(renderTarget, new Color4(0.5f, 0.5f, 1.0f));
                swapChain.Present(0, PresentFlags.None);
            });
        }
    }
}
