using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_Books
{
    class clsFile_Header
    {
        public int header_length = 200;
        public string app_id = "123";
        public string file_id = "123";
        public string file_version="1.0";
        public string validator_1 = "";
        public string validator_2 = "";
        public string validator_3 = "";

        public List<string> exceptions = new List<string>();    
        public enum load_result
        {
            Successful=1,
            Invalid=2,
            Trapped_Error=3
        }

        public load_result validate(string file_header_content)
        {
            this.exceptions.Clear();
            try
            {
                if (file_header_content.Length!=this.header_length)
                {
                    this.exceptions.Add("Illegal header length.");
                }
                if (!file_header_content.Contains('\t'))
                {
                    this.exceptions.Add("Illegal Header Format.");
                    return load_result.Invalid;
                }
                string[] fields = file_header_content.Split('\t');
                if (fields.Length<6)
                {
                    this.exceptions.Add("Incomplete Header Format.");
                    return load_result.Invalid;
                }
                if (fields[0]!=this.app_id) { this.exceptions.Add("Incorrect app id."); }
                if (fields[1] != this.file_id) { this.exceptions.Add("Incorrect file id."); }
                if (fields[2] != this.file_version) { this.exceptions.Add("Incorrect file version."); }
                if (this.validator_1 != "")
                {
                    if (fields[3] != this.validator_1) { this.exceptions.Add("Invalid entry 1."); }
                }
                if (this.validator_2 != "")
                {
                    if (fields[4] != this.validator_2) { this.exceptions.Add("Invalid entry 2."); }
                }
                if (this.validator_3 != "")
                {
                    if (fields[5] != this.validator_3) { this.exceptions.Add("Invalid entry 3."); }
                }
                if (this.exceptions.Count > 0) return load_result.Invalid;
            }
            catch (Exception ex)
            {
                this.exceptions.Add(ex.Message);
                return load_result.Trapped_Error;
            }
            return load_result.Successful;
        }

        /// <summary>
        /// The header encoding is fixed-length
        /// If the encoded data surpases the define header size
        /// it will be truncated
        /// </summary>
        /// <returns></returns>
        public string DLM()
        {
            string rv = "";
            rv += this.app_id + "\t";
            rv += this.file_id + "\t";
            rv += this.file_version + "\t";
            rv += this.validator_1 + "\t";
            rv += this.validator_2 + "\t";
            rv += this.validator_3 + "\t";
            if (rv.Length>this.header_length-1)
            {
                rv=rv.Substring(0,this.header_length-1) + '\0';
            }
            else
            {
                rv += new string('\0', this.header_length - rv.Length);
            }
            return rv;
        }

        public void Populate(string value)
        {
            int h_term_point = value.IndexOf('\0');
            if (h_term_point < 6) return;
            string data = value.Substring(0, h_term_point);
            string[] fields = data.Split('\t');
            if (fields.Length > 0) this.app_id = fields[0];
            if (fields.Length > 1) this.file_id = fields[1];
            if (fields.Length > 2) this.file_version = fields[2];
            if (fields.Length > 3) this.validator_1 = fields[3];
            if (fields.Length > 4) this.validator_2 = fields[4];
            if (fields.Length > 5) this.validator_3 = fields[5];
        }

    }
}
