﻿using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXing.Net.Maui.Controls
{
	public partial class CameraCaptureView : View, ICameraCaptureView
	{
		public event EventHandler Started;
	}
}
