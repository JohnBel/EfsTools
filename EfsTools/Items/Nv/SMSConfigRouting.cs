using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(830)]
    [Attributes(9)]
    public sealed class SmsConfigRouting
    {
        public byte PPRoutes1 { get; set; }


        public byte PPMemStores1 { get; set; }


        public byte BCRoutes1 { get; set; }


        public byte BCMemStores1 { get; set; }


        public byte PPRoutes2 { get; set; }


        public byte PPMemStores2 { get; set; }


        public byte BCRoutes2 { get; set; }


        public byte BCMemStores2 { get; set; }


        public byte PPRoutes3 { get; set; }


        public byte PPMemStores3 { get; set; }


        public byte BCRoutes3 { get; set; }


        public byte BCMemStores3 { get; set; }


        public byte PPRoutes4 { get; set; }


        public byte PPMemStores4 { get; set; }


        public byte BCRoutes4 { get; set; }


        public byte BCMemStores4 { get; set; }


        public byte PPRoutes5 { get; set; }


        public byte PPMemStores5 { get; set; }


        public byte BCRoutes5 { get; set; }


        public byte BCMemStores5 { get; set; }


        public byte PPRoutes6 { get; set; }


        public byte PPMemStores6 { get; set; }


        public byte BCRoutes6 { get; set; }


        public byte BCMemStores6 { get; set; }


        public byte TransferStatusReport { get; set; }
    }
}