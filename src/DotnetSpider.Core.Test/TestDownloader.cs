﻿using DotnetSpider.Core.Downloader;

namespace DotnetSpider.Core.Test
{
	public class TestDownloader : BaseDownloader
	{
		protected override Page DowloadContent(Request request, ISpider spider)
		{
			return new Page(request, ContentType.Html)
			{
				Url = request.Url.ToString(),
				Content = "aabbcccdefg下载人数100"
			};
		}
	}
}
