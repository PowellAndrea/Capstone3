
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata_Manager.Models
{

   public class EditingGrid : DataGridView
   {
		// implemented as a singleton
		public Lazy<EditingGrid> lazy = 
         new Lazy<EditingGrid>(() => new EditingGrid());

      public EditingGrid Instance { get { return lazy.Value; } }

   }
}
// Use fields from the Record object to generate table, instead of addig to .net generated columns.
// File Name | Title | Year Published | Start Year | End Year| Author | Record Series | File Path
