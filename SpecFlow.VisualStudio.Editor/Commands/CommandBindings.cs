using System.ComponentModel.Composition;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Editor.Commanding;
using Microsoft.VisualStudio.Text.Editor.Commanding.Commands;

namespace SpecFlow.VisualStudio.Editor.Commands
{
    internal sealed class CommandBindings
    {
        [Export]
        [CommandBinding(VSConstants.CMDSETID.StandardCommandSet2K_string, (uint)VSConstants.VSStd2KCmdID.COMMENT_BLOCK, typeof(CommentSelectionCommandArgs))]
        internal CommandBindingDefinition commentCommandBindings = null;

        [Export]
        [CommandBinding(VSConstants.CMDSETID.StandardCommandSet2K_string, (uint)VSConstants.VSStd2KCmdID.UNCOMMENT_BLOCK, typeof(UncommentSelectionCommandArgs))]
        internal CommandBindingDefinition uncommentCommandBindings = null;
    }
}