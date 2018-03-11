using System;
using System.Collections.Generic;
using System.Text;

namespace InControls.PLC.FX
{
    /// <summary>
    /// FX命令常量。
    /// </summary>
	public enum FxCommandConst : byte			// 命令字
	{
        /// <summary>
        /// 元件读取，X,Y,M,S,T,C,D 
        /// </summary>
		FxCmdRead = 0x30,						// 元件读取，X,Y,M,S,T,C,D 

        /// <summary>
        /// 元件写入，X,Y,M,S,T,C,D 
        /// </summary>
		FxCmdWrite = 0x31,						// 元件写入，X,Y,M,S,T,C,D 

        /// <summary>
        /// 强迫ON，X,Y,M,S,T,C 
        /// </summary>
		FxCmdForceOn = 0x37,					// 强迫ON，X,Y,M,S,T,C 

        /// <summary>
        /// 强迫OFF，X,Y,M,S,T,C
        /// </summary>
		FxCmdForceOff = 0x38,					// 强迫OFF，X,Y,M,S,T,C
	}

    /// <summary>
    /// FX响应常量。
    /// </summary>
	public enum FxResponseConst : byte			// 命令字
	{
        /// <summary>
        /// 接受正确。
        /// </summary>
		FxACK = FxControlCode._ACK,				//接受正确

        /// <summary>
        /// 接受错误。
        /// </summary>
		FxNAK = FxControlCode._NAK,				//接受错误
	}

	/// <summary>
	/// 控制代码
	/// </summary>
	public class FxControlCode
	{
        /// <summary>
        /// NULL.
        /// </summary>
		public const byte _NUL = 0x00;			//  NULL 

        /// <summary>
        /// 主机报文开始
        /// </summary>
		public const byte _STX = 0x02;			//  主机报文开始 

        /// <summary>
        /// 主机报文结束
        /// </summary>
		public const byte _ETX = 0x03;			//  主机报文结束

        /// <summary>
        /// End of Transmission
        /// </summary>
		public const byte _EOT = 0x04;			//  End of Transmission

        /// <summary>
        /// （从机）来自从机的请求信号 
        /// </summary>
		public const byte _ENQ = 0x05;			//  （从机）来自从机的请求信号 

        /// <summary>
        /// （从机）PLC正确响应 
        /// </summary>
		public const byte _ACK = 0x06;			//  （从机）PLC正确响应 

        /// <summary>
        /// （从机）PLC错误响应 
        /// </summary>
		public const byte _NAK = 0x15;			//  （从机）PLC错误响应 

        /// <summary>
        /// Body Link Escape
        /// </summary>
		public const byte _DLE = 0x10;			//  Body Link Escape

		public const byte _LF = 0x0A;			//  
		public const byte _CR = 0x0D;			//  


		public const byte _CLEAR = 0x0C;		//  
	}

    /// <summary>
    /// FX地址布局类型。
    /// </summary>
	public enum FxAddressLayoutType : ushort
	{
		AddressLayoutBin = 1,
		AddressLayoutByte = 2,
		AddressLayoutInt16 = 3,
		AddressLayoutInt32 = 4,
	}

    /// <summary>
    /// FX地址类型。
    /// </summary>
	public enum FxAddressType : short
	{
		X = 1,
		Y = 2,
		M = 3,
		S = 4,
		T = 5,
		C = 6,
		D = 7,

		/// <summary>
		/// 常数
		/// </summary>
		K = 8,

		Undefine = 0,								// 为定义的错误地址类型
	}


}
