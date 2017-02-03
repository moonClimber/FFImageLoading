﻿using System;
using System.Net.Http;
using FFImageLoading.Helpers;
using FFImageLoading.Cache;
using FFImageLoading.Work;

namespace FFImageLoading.Config
{
	/// <summary>
	/// Configuration.
	/// </summary>
	public class Configuration
    {
		public Configuration()
		{
			// default values here:
			MaxMemoryCacheSize = 0; 
			BitmapOptimizations = true;
			FadeAnimationEnabled = true;
			FadeAnimationForCachedImages = false; // by default cached images will not fade when displayed on screen, otherwise it gives the impression that UI is laggy
			FadeAnimationDuration = 300;
			TransformPlaceholders = true;
			DownsampleInterpolationMode = InterpolationMode.Default;
			HttpHeadersTimeout = 10;
			HttpReadTimeout = 30;
            VerbosePerformanceLogging = false;
            VerboseMemoryCacheLogging = false;
            VerboseLoadingCancelledLogging = false;
            VerboseLogging = false;
            SchedulerMaxParallelTasks = Math.Min(4, Math.Max(2, (int)(Environment.ProcessorCount / 2d)));
            DiskCacheDuration = TimeSpan.FromDays(30d);
            ExecuteCallbacksOnUIThread = false;
            StreamChecksumsAsKeys = true;
		}

		/// <summary>
		/// Gets or sets the http client used for web requests.
		/// </summary>
		/// <value>The http client used for web requests.</value>
		public HttpClient HttpClient { get; set; }

		/// <summary>
		/// Gets or sets the scheduler used to organize/schedule image loading tasks.
		/// </summary>
		/// <value>The scheduler used to organize/schedule image loading tasks.</value>
		public IWorkScheduler Scheduler { get; set; }

		/// <summary>
		/// Gets or sets the logger used to receive debug/error messages.
		/// </summary>
		/// <value>The logger.</value>
		public IMiniLogger Logger { get; set; }

		/// <summary>
		/// Gets or sets the disk cache.
		/// </summary>
		/// <value>The disk cache.</value>
		public IDiskCache DiskCache { get; set; }

        /// <summary>
        /// Gets or sets the disk cache path.
        /// </summary>
        /// <value>The disk cache path.</value>
        public string DiskCachePath { get; set; }

		/// <summary>
		/// Gets or sets the download cache. Download cache is responsible for retrieving data from the web, or taking from the disk cache.
		/// </summary>
		/// <value>The download cache.</value>
		public IDownloadCache DownloadCache { get; set; }

        /// <summary>
        /// Gets or sets the image data resolver factory.
        /// </summary>
        /// <value>The data resolver factory.</value>
        public IDataResolverFactory DataResolverFactory { get; set; }

        /// <summary>
        /// Gets or sets the MD5 helper.
        /// </summary>
        /// <value>The MD5 helper.</value>
        public IMD5Helper MD5Helper { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="FFImageLoading.Config.Configuration"/> loads images with transparency channel. On Android we save 50% of the memory without transparency since we use 2 bytes per pixel instead of 4.
		/// </summary>
		/// <value><c>true</c> if FFIMageLoading loads images with transparency; otherwise, <c>false</c>.</value>
        [Obsolete]
        public bool LoadWithTransparencyChannel
        {
            get { return BitmapOptimizations; }
            set { BitmapOptimizations = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:FFImageLoading.Config.Configuration"/> bitmap
        /// memory optimizations.
        /// </summary>
        /// <value><c>true</c> if bitmap memory optimizations; otherwise, <c>false</c>.</value>
        public bool BitmapOptimizations { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:FFImageLoading.Config.Configuration"/> stream
        /// checksums as keys.
        /// </summary>
        /// <value><c>true</c> if stream checksums as keys; otherwise, <c>false</c>.</value>
        public bool StreamChecksumsAsKeys { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="FFImageLoading.Config.Configuration"/> fade animation enabled.
		/// </summary>
		/// <value><c>true</c> if fade animation enabled; otherwise, <c>false</c>.</value>
		public bool FadeAnimationEnabled { get; set; }

		/// <summary>
		/// Gets or sets a value indicating wheter fade animation for
		/// cached or local images should be enabled.
		/// </summary>
		/// <value><c>true</c> if fade animation for cached or local images; otherwise, <c>false</c>.</value>
		public bool FadeAnimationForCachedImages { get; set; }

		/// <summary>
		/// Gets or sets the default duration of the fade animation in ms.
		/// </summary>
		/// <value>The duration of the fade animation.</value>
		public int FadeAnimationDuration { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="FFImageLoading.Config.Configuration"/> transforming place is enabled.
		/// </summary>
		/// <value><c>true</c> if transform should be applied to placeholder images; otherwise, <c>false</c>.</value>
		public bool TransformPlaceholders { get; set; }

		/// <summary>
		/// Gets or sets default downsample interpolation mode.
		/// </summary>
		/// <value>downsample interpolation mode</value>
		public InterpolationMode DownsampleInterpolationMode { get; set; }

		/// <summary>
		/// Gets or sets the maximum time in seconds to wait to receive HTTP headers before the HTTP request is cancelled.
		/// </summary>
		/// <value>The http connect timeout.</value>
		public int HttpHeadersTimeout { get; set; }

		/// <summary>
		/// Gets or sets the maximum time in seconds to wait before the HTTP request is cancelled.
		/// </summary>
		/// <value>The http read timeout.</value>
		public int HttpReadTimeout { get; set; }

		/// <summary>
		/// Gets or sets the maximum size of the memory cache in bytes.
		/// </summary>
		/// <value>The maximum size of the memory cache in bytes.</value>
		public int MaxMemoryCacheSize { get; set; }

		/// <summary>
		/// Milliseconds to wait prior to start any task.
		/// </summary>
		public int DelayInMs { get; set; }

        /// <summary>
        /// Enables / disables verbose performance logging.
        /// WARNING! It will downgrade image loading performance, disable it for release builds!
        /// </summary>
        /// <value>The verbose performance logging.</value>
        public bool VerbosePerformanceLogging { get; set; }

        /// <summary>
        /// Enables / disables verbose memory cache logging.
        /// WARNING! It will downgrade image loading performance, disable it for release builds!
        /// </summary>
        /// <value>The verbose memory cache logging.</value>
        public bool VerboseMemoryCacheLogging { get; set; }

        /// <summary>
        /// Enables / disables verbose image loading cancelled logging.
        /// WARNING! It will downgrade image loading performance, disable it for release builds!
        /// </summary>
        /// <value>The verbose image loading cancelled logging.</value>
        public bool VerboseLoadingCancelledLogging { get; set; }

        /// <summary>
        /// Enables / disables  verbose logging. 
        /// IMPORTANT! If it's disabled are other verbose logging options are disabled too
        /// </summary>
        /// <value>The verbose logging.</value>
        public bool VerboseLogging { get; set; }

        /// <summary>
        /// Gets or sets the scheduler max parallel tasks.
        /// Default is: Math.Max(2, (int)(Environment.ProcessorCount / 2d))
        /// </summary>
        /// <value>The scheduler max parallel tasks.</value>
        public int SchedulerMaxParallelTasks { get; set; }

        /// <summary>
        /// Gets or sets the scheduler max parallel tasks factory.
        /// If null SchedulerMaxParallelTasks property is used
        /// </summary>
        /// <value>The scheduler max parallel tasks factory.</value>
        public Func<Configuration, int> SchedulerMaxParallelTasksFactory { get; set; }

        /// <summary>
        /// Gets or sets the default duration of the disk cache entries.
        /// </summary>
        /// <value>The duration of the cache.</value>
        public TimeSpan DiskCacheDuration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether callbacs (OnFinish, OnSuccess, etc) 
        /// should execute on UI thread
        /// </summary>
        /// <value><c>true</c> if execute callbacks on UIT hread; otherwise, <c>false</c>.</value>
        public bool ExecuteCallbacksOnUIThread { get; set; }
    }
}

