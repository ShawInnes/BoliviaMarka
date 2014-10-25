﻿using System.Web.Optimization;

namespace Website
{
	public static class BundleConfig
	{
		public static void Register(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/assets/plugins/jquery-1.10.2.min.js",
				"~/assets/plugins/jquery-migrate-1.2.1.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
				"~/assets/plugins/bootstrap/js/bootstrap.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/revolution").Include(
				"~/assets/plugins/revolution-slider/examples/rs-plugin/js/jquery.themepunch.plugins.min.js",
				"~/assets/plugins/revolution-slider/examples/rs-plugin/js/jquery.themepunch.revolution.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/galleria")
				.Include("~/assets/plugins/galleria/galleria-1.4.2.js"));

			bundles.Add(new StyleBundle("~/bundles/css")
				.Include("~/assets/plugins/bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform())
				.Include("~/assets/css/style.css", new CssRewriteUrlTransform())
				.Include("~/assets/plugins/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform())
				.Include("~/assets/plugins/revolution-slider/examples/rs-plugin/css/settings.css", new CssRewriteUrlTransform())
				.Include("~/assets/css/custom.css", new CssRewriteUrlTransform()));
			
			BundleTable.EnableOptimizations = false;
		}
	}
}