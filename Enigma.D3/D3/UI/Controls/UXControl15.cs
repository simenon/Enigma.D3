using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma.D3.UI.Controls
{
	internal class UXControl15 : UXItemsControl
	{
		public new const int SizeOf = 0xDD0;
		public new const int VTable = 0x01752CF0;

		public int _xA48 { get { return Read<int>(0xA48); } }
		public int _xA4C { get { return Read<int>(0xA4C); } }
		public int _xA50 { get { return Read<int>(0xA50); } }
		public int _xA54 { get { return Read<int>(0xA54); } }
		public int _xA58 { get { return Read<int>(0xA58); } }
		public int _xA5C { get { return Read<int>(0xA5C); } }
		public int _xA60 { get { return Read<int>(0xA60); } }
		public int _xA64 { get { return Read<int>(0xA64); } }
		public int _xA68 { get { return Read<int>(0xA68); } }
		public int _xA6C { get { return Read<int>(0xA6C); } }
		public int _xA70 { get { return Read<int>(0xA70); } }
		public int _xA74 { get { return Read<int>(0xA74); } }
		public int _xA78 { get { return Read<int>(0xA78); } }
		public int _xA7C { get { return Read<int>(0xA7C); } }
		public int _xA80 { get { return Read<int>(0xA80); } }
		public int _xA84 { get { return Read<int>(0xA84); } }
		public int _xA88 { get { return Read<int>(0xA88); } }
		public int _xA8C { get { return Read<int>(0xA8C); } }
		public int _xA90 { get { return Read<int>(0xA90); } }
		public int _xA94 { get { return Read<int>(0xA94); } }
		public int _xA98 { get { return Read<int>(0xA98); } }
		public int _xA9C { get { return Read<int>(0xA9C); } }
		public int _xAA0 { get { return Read<int>(0xAA0); } }
		public int _xAA4 { get { return Read<int>(0xAA4); } }
		public int _xAA8 { get { return Read<int>(0xAA8); } }
		public int _xAAC { get { return Read<int>(0xAAC); } }
		public int _xAB0 { get { return Read<int>(0xAB0); } }
		public int _xAB4 { get { return Read<int>(0xAB4); } }
		public int _xAB8 { get { return Read<int>(0xAB8); } }
		public int _xABC { get { return Read<int>(0xABC); } }
		public int _xAC0 { get { return Read<int>(0xAC0); } }
		public int _xAC4 { get { return Read<int>(0xAC4); } }
		public int _xAC8 { get { return Read<int>(0xAC8); } }
		public int _xACC { get { return Read<int>(0xACC); } }
		public int _xAD0 { get { return Read<int>(0xAD0); } }
		public int _xAD4 { get { return Read<int>(0xAD4); } }
		public int _xAD8 { get { return Read<int>(0xAD8); } }
		public int _xADC { get { return Read<int>(0xADC); } }
		public int _xAE0 { get { return Read<int>(0xAE0); } }
		public int _xAE4 { get { return Read<int>(0xAE4); } }
		public int _xAE8 { get { return Read<int>(0xAE8); } }
		public int _xAEC { get { return Read<int>(0xAEC); } }
		public int _xAF0 { get { return Read<int>(0xAF0); } }
		public int _xAF4 { get { return Read<int>(0xAF4); } }
		public int _xAF8 { get { return Read<int>(0xAF8); } }
		public int _xAFC { get { return Read<int>(0xAFC); } }
		public int _xB00 { get { return Read<int>(0xB00); } }
		public int _xB04 { get { return Read<int>(0xB04); } }
		public int _xB08 { get { return Read<int>(0xB08); } }
		public int _xB0C { get { return Read<int>(0xB0C); } }
		public int _xB10 { get { return Read<int>(0xB10); } }
		public int _xB14 { get { return Read<int>(0xB14); } }
		public int _xB18 { get { return Read<int>(0xB18); } }
		public int _xB1C { get { return Read<int>(0xB1C); } }
		public int _xB20 { get { return Read<int>(0xB20); } }
		public int _xB24 { get { return Read<int>(0xB24); } }
		public int _xB28 { get { return Read<int>(0xB28); } }
		public int _xB2C { get { return Read<int>(0xB2C); } }
		public int _xB30 { get { return Read<int>(0xB30); } }
		public int _xB34 { get { return Read<int>(0xB34); } }
		public int _xB38 { get { return Read<int>(0xB38); } }
		public int _xB3C { get { return Read<int>(0xB3C); } }
		public int _xB40 { get { return Read<int>(0xB40); } }
		public int _xB44 { get { return Read<int>(0xB44); } }
		public int _xB48 { get { return Read<int>(0xB48); } }
		public int _xB4C { get { return Read<int>(0xB4C); } }
		public int _xB50 { get { return Read<int>(0xB50); } }
		public int _xB54 { get { return Read<int>(0xB54); } }
		public int _xB58 { get { return Read<int>(0xB58); } }
		public int _xB5C { get { return Read<int>(0xB5C); } }
		public int _xB60 { get { return Read<int>(0xB60); } }
		public int _xB64 { get { return Read<int>(0xB64); } }
		public int _xB68 { get { return Read<int>(0xB68); } }
		public int _xB6C { get { return Read<int>(0xB6C); } }
		public int _xB70 { get { return Read<int>(0xB70); } }
		public int _xB74 { get { return Read<int>(0xB74); } }
		public int _xB78 { get { return Read<int>(0xB78); } }
		public int _xB7C { get { return Read<int>(0xB7C); } }
		public int _xB80 { get { return Read<int>(0xB80); } }
		public int _xB84 { get { return Read<int>(0xB84); } }
		public int _xB88 { get { return Read<int>(0xB88); } }
		public int _xB8C { get { return Read<int>(0xB8C); } }
		public int _xB90 { get { return Read<int>(0xB90); } }
		public int _xB94 { get { return Read<int>(0xB94); } }
		public int _xB98 { get { return Read<int>(0xB98); } }
		public int _xB9C { get { return Read<int>(0xB9C); } }
		public int _xBA0 { get { return Read<int>(0xBA0); } }
		public int _xBA4 { get { return Read<int>(0xBA4); } }
		public int _xBA8 { get { return Read<int>(0xBA8); } }
		public int _xBAC { get { return Read<int>(0xBAC); } }
		public int _xBB0 { get { return Read<int>(0xBB0); } }
		public int _xBB4 { get { return Read<int>(0xBB4); } }
		public int _xBB8 { get { return Read<int>(0xBB8); } }
		public int _xBBC { get { return Read<int>(0xBBC); } }
		public int _xBC0 { get { return Read<int>(0xBC0); } }
		public int _xBC4 { get { return Read<int>(0xBC4); } }
		public int _xBC8 { get { return Read<int>(0xBC8); } }
		public int _xBCC { get { return Read<int>(0xBCC); } }
		public int _xBD0 { get { return Read<int>(0xBD0); } }
		public int _xBD4 { get { return Read<int>(0xBD4); } }
		public int _xBD8 { get { return Read<int>(0xBD8); } }
		public int _xBDC { get { return Read<int>(0xBDC); } }
		public int _xBE0 { get { return Read<int>(0xBE0); } }
		public int _xBE4 { get { return Read<int>(0xBE4); } }
		public int _xBE8 { get { return Read<int>(0xBE8); } }
		public int _xBEC { get { return Read<int>(0xBEC); } }
		public int _xBF0 { get { return Read<int>(0xBF0); } }
		public int _xBF4 { get { return Read<int>(0xBF4); } }
		public int _xBF8 { get { return Read<int>(0xBF8); } }
		public int _xBFC { get { return Read<int>(0xBFC); } }
		public int _xC00 { get { return Read<int>(0xC00); } }
		public int _xC04 { get { return Read<int>(0xC04); } }
		public int _xC08 { get { return Read<int>(0xC08); } }
		public int _xC0C { get { return Read<int>(0xC0C); } }
		public int _xC10 { get { return Read<int>(0xC10); } }
		public int _xC14 { get { return Read<int>(0xC14); } }
		public int _xC18 { get { return Read<int>(0xC18); } }
		public int _xC1C { get { return Read<int>(0xC1C); } }
		public int _xC20 { get { return Read<int>(0xC20); } }
		public int _xC24 { get { return Read<int>(0xC24); } }
		public int _xC28 { get { return Read<int>(0xC28); } }
		public int _xC2C { get { return Read<int>(0xC2C); } }
		public int _xC30 { get { return Read<int>(0xC30); } }
		public int _xC34 { get { return Read<int>(0xC34); } }
		public int _xC38 { get { return Read<int>(0xC38); } }
		public int _xC3C { get { return Read<int>(0xC3C); } }
		public int _xC40 { get { return Read<int>(0xC40); } }
		public int _xC44 { get { return Read<int>(0xC44); } }
		public int _xC48 { get { return Read<int>(0xC48); } }
		public int _xC4C { get { return Read<int>(0xC4C); } }
		public int _xC50 { get { return Read<int>(0xC50); } }
		public int _xC54 { get { return Read<int>(0xC54); } }
		public int _xC58 { get { return Read<int>(0xC58); } }
		public int _xC5C { get { return Read<int>(0xC5C); } }
		public int _xC60 { get { return Read<int>(0xC60); } }
		public int _xC64 { get { return Read<int>(0xC64); } }
		public int _xC68 { get { return Read<int>(0xC68); } }
		public int _xC6C { get { return Read<int>(0xC6C); } }
		public int _xC70 { get { return Read<int>(0xC70); } }
		public int _xC74 { get { return Read<int>(0xC74); } }
		public int _xC78 { get { return Read<int>(0xC78); } }
		public int _xC7C { get { return Read<int>(0xC7C); } }
		public int _xC80 { get { return Read<int>(0xC80); } }
		public int xC84_VTable { get { return Read<int>(0xC84); } }
		public int xC88 { get { return Read<int>(0xC88); } }
		public int xC8C_Neg1 { get { return Read<int>(0xC8C); } }
		public int xC90_VTable { get { return Read<int>(0xC90); } }
		public int xC94 { get { return Read<int>(0xC94); } }
		public int xC98_VTable { get { return Read<int>(0xC98); } }
		public int xC9C { get { return Read<int>(0xC9C); } }
		public int xCA0_VTable { get { return Read<int>(0xCA0); } }
		public int xCA4 { get { return Read<int>(0xCA4); } }
		public int xCA8_VTable { get { return Read<int>(0xCA8); } }
		public int xCAC { get { return Read<int>(0xCAC); } }
		public int xCB0_VTable { get { return Read<int>(0xCB0); } }
		public int xCB4 { get { return Read<int>(0xCB4); } }
		public int xCB8_VTable { get { return Read<int>(0xCB8); } }
		public int xCBC { get { return Read<int>(0xCBC); } }
		public int xCC0_VTable { get { return Read<int>(0xCC0); } }
		public int xCC4 { get { return Read<int>(0xCC4); } }
		public int xCC8_VTable { get { return Read<int>(0xCC8); } }
		public int xCCC { get { return Read<int>(0xCCC); } }
		public int xCD0_VTable { get { return Read<int>(0xCD0); } }
		public int xCD4 { get { return Read<int>(0xCD4); } }
		public int xCD8_VTable { get { return Read<int>(0xCD8); } }
		public int xCDC { get { return Read<int>(0xCDC); } }
		public int xCE0_VTable { get { return Read<int>(0xCE0); } }
		public int xCE4 { get { return Read<int>(0xCE4); } }
		public int xCE8_VTable { get { return Read<int>(0xCE8); } }
		public int xCEC { get { return Read<int>(0xCEC); } }
		public int xCF0_VTable { get { return Read<int>(0xCF0); } }
		public int xCF4 { get { return Read<int>(0xCF4); } }
		public int xCF8_StructStart { get { return Read<int>(0xCF8); } }
		public int _xCFC { get { return Read<int>(0xCFC); } }
		public int _xD00 { get { return Read<int>(0xD00); } }
		public int _xD04 { get { return Read<int>(0xD04); } }
		public int _xD08 { get { return Read<int>(0xD08); } }
		public int _xD0C { get { return Read<int>(0xD0C); } }
		public int _xD10 { get { return Read<int>(0xD10); } }
		public int _xD14 { get { return Read<int>(0xD14); } }
		public int _xD18 { get { return Read<int>(0xD18); } }
		public int _xD1C { get { return Read<int>(0xD1C); } }
		public int _xD20 { get { return Read<int>(0xD20); } }
		public int _xD24 { get { return Read<int>(0xD24); } }
		public int _xD28 { get { return Read<int>(0xD28); } }
		public int _xD2C { get { return Read<int>(0xD2C); } }
		public int _xD30 { get { return Read<int>(0xD30); } }
		public int _xD34 { get { return Read<int>(0xD34); } }
		public int _xD38 { get { return Read<int>(0xD38); } }
		public int _xD3C { get { return Read<int>(0xD3C); } }
		public int _xD40 { get { return Read<int>(0xD40); } }
		public int _xD44 { get { return Read<int>(0xD44); } }
		public int _xD48 { get { return Read<int>(0xD48); } }
		public int _xD4C { get { return Read<int>(0xD4C); } }
		public int _xD50 { get { return Read<int>(0xD50); } }
		public int _xD54 { get { return Read<int>(0xD54); } }
		public int _xD58 { get { return Read<int>(0xD58); } }
		public int _xD5C { get { return Read<int>(0xD5C); } }
		public int _xD60 { get { return Read<int>(0xD60); } }
		public int _xD64 { get { return Read<int>(0xD64); } }
		public int _xD68 { get { return Read<int>(0xD68); } }
		public int _xD6C { get { return Read<int>(0xD6C); } }
		public int _xD70 { get { return Read<int>(0xD70); } }
		public int _xD74 { get { return Read<int>(0xD74); } }
		public int _xD78 { get { return Read<int>(0xD78); } }
		public int _xD7C { get { return Read<int>(0xD7C); } }
		public int _xD80 { get { return Read<int>(0xD80); } }
		public int _xD84 { get { return Read<int>(0xD84); } }
		public int _xD88 { get { return Read<int>(0xD88); } }
		public int _xD8C { get { return Read<int>(0xD8C); } }
		public int _xD90 { get { return Read<int>(0xD90); } }
		public int _xD94 { get { return Read<int>(0xD94); } }
		public int _xD98 { get { return Read<int>(0xD98); } }
		public int _xD9C { get { return Read<int>(0xD9C); } }
		public int _xDA0 { get { return Read<int>(0xDA0); } }
		public int _xDA4 { get { return Read<int>(0xDA4); } }
		public int _xDA8 { get { return Read<int>(0xDA8); } }
		public int _xDAC { get { return Read<int>(0xDAC); } }
		public int _xDB0 { get { return Read<int>(0xDB0); } }
		public int _xDB4 { get { return Read<int>(0xDB4); } }
		public int _xDB8 { get { return Read<int>(0xDB8); } }
		public int _xDBC { get { return Read<int>(0xDBC); } }
		public int _xDC0 { get { return Read<int>(0xDC0); } }
		public int _xDC4 { get { return Read<int>(0xDC4); } }
		public int _xDC8 { get { return Read<int>(0xDC8); } }
		public int _xDCC { get { return Read<int>(0xDCC); } }
	}
}
