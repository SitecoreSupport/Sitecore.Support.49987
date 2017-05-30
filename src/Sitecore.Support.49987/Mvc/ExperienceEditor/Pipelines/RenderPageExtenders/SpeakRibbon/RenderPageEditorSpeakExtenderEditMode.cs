namespace Sitecore.Support.Mvc.ExperienceEditor.Pipelines.RenderPageExtenders.SpeakRibbon
{
    using Sitecore.ExperienceEditor.Pipelines.GetExperienceEditorRibbon;
    using Sitecore.Mvc.ExperienceEditor.Pipelines.RenderPageExtenders;
    using Sitecore.Pipelines;
    using Sitecore.Web.UI;
    using System;
    using System.IO;

    public class RenderPageEditorSpeakExtenderEditMode : RenderPageEditorExtender
    {
        protected override bool Render(TextWriter writer)
        {
            GetExperienceEditorRibbonArgs args = new GetExperienceEditorRibbonArgs();
            CorePipeline.Run("getExperienceEditorRibbon", args);
            WebControl control = args.Control as WebControl;
            if (control == null)
            {
                return false;
            }
            writer.Write(control.RenderAsText());
            return true;
        }
    }
}