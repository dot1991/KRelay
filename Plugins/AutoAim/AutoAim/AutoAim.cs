using System;
using Lib_K_Relay;
using Lib_K_Relay.Interface;

namespace AutoAim {
    public class AutoAim : IPlugin {
        public void Initialize(Proxy proxy) {
            throw new NotImplementedException();
        }

        public string GetAuthor() {
            return "lune";
        }

        public string[] GetCommands() {
            return new[] {
                "/autoaim [on | off] - Toggle Auto Aim on or off"
            };
        }

        public string GetDescription() {
            return "Automatically aims at vulnerable enemies";
        }

        public string GetName() {
            return "Auto Aim";
        }
    }
}
