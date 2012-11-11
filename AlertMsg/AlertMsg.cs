using System;
using DevExpress.XtraBars.Alerter;

namespace AlertMsg
{

    public class AlertMsg :AlertControl
    {

        public AlertMsg()
        {
            AutoFormDelay = 5000;
            AllowHtmlText = true;
        }
        public AlertMsg(System.ComponentModel.IContainer container)
            : base(container)
        {
            
        }
         

        public void Show(string Titulo, string Texto, Imagenes Img)
        {
            switch (Img)
            { 
                case Imagenes.Informacion:
                    Show(null, Titulo, Texto, global::AlertMsg.Properties.Resources.SymbolInformation);
                    break;
                case Imagenes.Advertencia:
                    Show(null, Titulo, Texto, global::AlertMsg.Properties.Resources.SymbolExclamation);
                    break;
                case Imagenes.Error:
                    Show(null, Titulo, Texto, global::AlertMsg.Properties.Resources.SymbolError);
                    break;
                case Imagenes.Notificacion:
                    Show(null, Titulo, Texto, global::AlertMsg.Properties.Resources.SymbolCheck);
                    break;
            }
        }
    }
}
