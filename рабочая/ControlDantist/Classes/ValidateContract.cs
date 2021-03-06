using System;
using System.Collections.Generic;
using System.Text;

namespace ControlDantist.Classes
{
    /// <summary>
    /// ������ ��������� �������� �������� �������� �� �������� ����� ����������
    /// </summary>
    public class ValidateContract
    {
        private List<����validate> ����Validate;
        private bool flag����;
        private List<ErrorsReestrUnload> listError;
        private bool flagError;

        // id ��������.
        public int Id������� { get; set; }

        // ����� ���������.
        public string SnilsPerson { get; set; }

        // ID ������ �������.
        public string IdRegionEsrn { get; set; }

        // ����� ������� �� �������.
        public string NameRegionRegistr { get; set; }

        //���� ������ ������ ������� �������� ��� ���
        private bool flagValidate;

        /// <summary>
        /// ��������� ��� �������� � ���� ����������
        /// </summary>
        public bool FlagPerson����
        {
            get
            {
                return flag����;
            }
            set
            {
                flag���� = value;
            }
        }

        /// <summary>
        /// ������ ������ ���������� ���������� ��� ������� ��������� � ����
        /// </summary>
        public List<����validate> ����������������
        {
            get
            {
                return ����Validate;
            }
            set
            {
                ����Validate = value;
            }
        }

        /// <summary>
        /// ������ ������ ����������� ��������� ������ � �����
        /// </summary>
        public List<ErrorsReestrUnload> �����������������
        {
            get
            {
                return listError;
            }
            set
            {
                listError = value;
            }
        }

        /// <summary>
        /// ���� ��������� �� ��������� ������ � ��������� ����� (���� true - ������ ���)
        /// </summary>
        public bool flagErrorSumm
        {
            get
            {
                return flagError;
            }
            set
            {
                flagError = value;
            }
        }


    
    }
}
