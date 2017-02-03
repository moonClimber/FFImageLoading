﻿using System;
using System.Threading.Tasks;
using FFImageLoading.Cache;
using FFImageLoading.Work;
using System.IO;

namespace FFImageLoading
{
    /// <summary>
    /// TaskParameterExtensions
    /// </summary>
	public static class TaskParameterExtensions
	{
		private const string DoNotReference = "You are referencing the Portable version in your App - you need to reference the platform (iOS/Android) version";

		/// <summary>
		/// Invalidate the image corresponding to given parameters from given caches.
		/// </summary>
		/// <param name="parameters">Image parameters.</param>
		/// <param name="cacheType">Cache type.</param>
		public static Task InvalidateAsync(this TaskParameter parameters, CacheType cacheType)
		{
			throw new Exception(DoNotReference);
		}

		/// <summary>
		/// Preloads the image request into memory cache/disk cache for future use.
		/// </summary>
		/// <param name="parameters">Image parameters.</param>
		public static IImageLoaderTask Preload(this TaskParameter parameters)
		{
			throw new Exception(DoNotReference);
		}

		/// <summary>
		/// Preloads the image request into memory cache/disk cache for future use.
		/// IMPORTANT: It throws image loading exceptions - you should handle them
		/// </summary>
		/// <param name="parameters">Image parameters.</param>
		public static Task PreloadAsync(this TaskParameter parameters)
		{
			throw new Exception(DoNotReference);
		}

		/// <summary>
		/// Downloads the image request into disk cache for future use if not already exists.
		/// Only Url Source supported.
		/// </summary>
		/// <param name="parameters">Image parameters.</param>
		public static IImageLoaderTask DownloadOnly(this TaskParameter parameters)
		{
			throw new Exception(DoNotReference);
		}

		/// <summary>
		/// Downloads the image request into disk cache for future use if not already exists.
		/// Only Url Source supported.
		/// IMPORTANT: It throws image loading exceptions - you should handle them
		/// </summary>
		/// <param name="parameters">Image parameters.</param>
		public static Task DownloadOnlyAsync(this TaskParameter parameters)
		{
			throw new Exception(DoNotReference);
		}

		/// <summary>
		/// Loads the image into PNG Stream
		/// </summary>
		/// <returns>The PNG Stream async.</returns>
		/// <param name="parameters">Parameters.</param>
		public static Task<Stream> AsPNGStreamAsync(this TaskParameter parameters)
		{
			throw new Exception(DoNotReference);
		}

		/// <summary>
		/// Loads the image into JPG Stream
		/// </summary>
		/// <returns>The JPG Stream async.</returns>
		/// <param name="parameters">Parameters.</param>
		public static Task<Stream> AsJPGStreamAsync(this TaskParameter parameters, int quality = 80)
		{
			throw new Exception(DoNotReference);
		}
	}
}

