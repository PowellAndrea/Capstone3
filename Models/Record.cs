#region Comments
/*
 * Andrea Powell 
 * Centralia College Capstone Project
 * Record Class
 * 
 * 
 *    should I create a new class pdfRecord : Record and add the PdfDocument and PdfDocumentInfo objects to that class?
 *    
 *    Look at public strings - use private with getters/setters?
 *    Add Cutoff Date to retention metadata, 
 *       is there an XMP template targeted to archivists?  
 *       Maybe the Library of Congress
 */
#endregion

using Metadata_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata_Manager
{
   public class Record
   {
      PdfRecord[] Records { get; set; }

      #region Class Properties
      // issues with internal and private strings - get/set revisit later

      internal Guid RecordId;
      /// PDF Internal version ID  xmpMM:InstanceID
      //public string PdfInstanceId;
      //internal string getDFWId { get; set; }

      internal string FileSize { get; }  // System managed

      public string FilePath;
      public string FileName;

      /// Dublin Core 1.1 Namespace (DCMI)
      /// https://developer.adobe.com/xmp/docs/XMPNamespaces/dc/
      public string Title;       //dc:title
      public string Author;      //dc:creator
      public string Description; //dc:description

      /// Pdfx 1.3 namespace - Custom Metdata
      public string RecordSeries;   //pdfx:RecordSeries


      public string Published;      //pdfx:Published - change this to use DCMI

      /// XMP Rights Management namespace --  //xmpRights:Marked = False  for Public Records
      public string CopyrightNotice;      //xmpRights:Marked = False

      #endregion

      public Record()
        {
			RecordId = Guid.NewGuid();

            // - chante to RecordID - several keys here to add. FileId = new Guid();
            //PdfInstanceId = string.Empty; // PDF Internal version ID - needs review  xmpMM:InstanceID
            FilePath = "  ";
            FileName = " ";
            //FileSize = string." ";  // System managed

            // Dublin Core 1.1 Namespace
            Title = " ";      //dc:title
            Author = " ";      //dc:creator
            Description = " ";   //dc:description
            /// Move to Record Set data
            //YearStart = string.Empty;     //pdfx:YearStart
            //YearEnd = string.Empty;       //pdfx:YearEnd
            Published = " ";     //pdfx:Published - change this to use DCMI
            RecordSeries = " ";  //pdfx:RecordSeries
        }
   }
}
