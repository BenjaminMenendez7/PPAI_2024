using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class InterfaceNotificacion
{
    public static void enviarNotificacion(List<string> nombres)
    {
        MessageBox.Show("Notificacion enviada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
