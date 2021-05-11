using System;

namespace Flex.Scripts.FlexUI.platinioTween.PlatinioTween.Scripts.Core
{
	public interface IRecyclable <T>
	{
		Action<T> Recycle { get; set; }
	}

}

