﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTVDTO;
using QLTVDAL;
namespace QLTVBUS
{
    public class LoaiDocGiaBUS
    {
        private LoaiDocGiaDAL ldgDAL;
        public String cmd_String;
        public LoaiDocGiaBUS()
        {
            ldgDAL = new LoaiDocGiaDAL();
        }
        public bool them(LoaiDocGiaDTO ldg)
        {
            bool re = ldgDAL.them(ldg);
            cmd_String = ldgDAL.cmd_string;
            return re;
        }

        public bool xoa(LoaiDocGiaDTO ldg)
        {
            bool re = ldgDAL.xoa(ldg);
            return re;
        }

        public bool sua(LoaiDocGiaDTO ldg)
        {
            bool re = ldgDAL.sua(ldg);
            return re;
        }

        public List<LoaiDocGiaDTO> select()
        {
            return ldgDAL.select();
        
        }
    }
}
