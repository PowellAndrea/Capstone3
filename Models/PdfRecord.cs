/*  Andrea Powell - 04/2/2022
 *  
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata_Manager.Models
{
   internal class PdfRecord : Record
   {
      public bool ShowPdfInBrowser(string _fileName)
      {

         //string FileName = "White-ParkerFamilyBible.pdf";
         string FileName = _fileName;
         try
         {
            System.Diagnostics.Process proc = new();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = FileName;
            proc.Start();
         }
         catch (System.ComponentModel.Win32Exception noBrowser)
         {  if (noBrowser.ErrorCode == -2147467259)
               MessageBox.Show(noBrowser.Message);
         }
         catch (System.Exception other)
         {
            MessageBox.Show(other.Message);
         }
         return true;
      }
   }
}
