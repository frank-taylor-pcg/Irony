using System.Collections.Generic;

namespace Irony.Parsing
{
  public abstract partial class ParserAction
  {

    public ParserAction() { }

    public virtual void Execute(ParsingContext context) { }

    public override string ToString()
    {
      return Resources.LabelActionUnknown; //should never happen
    }

  }//class ParserAction

  public class ParserActionTable : Dictionary<BnfTerm, ParserAction> { }

}
