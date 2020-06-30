using System;
using System.Collections.Generic;

namespace UOScript
{
    // This registers default handlers for all of the commands and expressions
    // so valid scripts will at least run for testing.
    public static class Commands
    {
        private static IComparable DummyExpression(string expression, Argument[] args, bool quiet)
        {
            Console.WriteLine("Executing expression {0} {1}", expression, args);

            return 0;
        }

        private static int DummyIntExpression(string expression, Argument[] args, bool quiet)
        {
            Console.WriteLine("Executing expression {0} {1}", expression, args);

            return 3;
        }

        private static string DummyStringExpression(string expression, Argument[] args, bool quiet)
        {
            Console.WriteLine("Executing expression {0} {1}", expression, args);

            return "test";
        }

        private static bool DummyCommand(string command, Argument[] args, bool quiet, bool force)
        {
            Console.WriteLine("Executing command {0} {1}", command, args);

            return true;
        }

        private static uint DummyAlias(string alias)
        {
            return 0;
        }

        private static bool MsgCommand(string command, Argument[] args, bool quiet, bool force)
        {
            Console.WriteLine("Msg {0}", args[0].AsString());

            return true;
        }

        public static void RegisterDummyCommands()
        {
            // Commands based on Actions.cs
            Interpreter.RegisterCommandHandler("attack", DummyCommand); //Attack by serial
            Interpreter.RegisterCommandHandler("cast", DummyCommand); //BookcastAction, etc

            // Dress
            Interpreter.RegisterCommandHandler("dress", DummyCommand); //DressAction
            Interpreter.RegisterCommandHandler("undress", DummyCommand); //UndressAction

            // Targets
            Interpreter.RegisterCommandHandler("target", DummyCommand); //Absolute Target
            Interpreter.RegisterCommandHandler("targettype", DummyCommand); //TargetTypeAction
            Interpreter.RegisterCommandHandler("targetrelloc", DummyCommand); //TargetRelLocAction

            Interpreter.RegisterCommandHandler("waitfortarget", DummyCommand); //WaitForTargetAction
            Interpreter.RegisterCommandHandler("wft", DummyCommand); //WaitForTargetAction

            // Using stuff
            Interpreter.RegisterCommandHandler("dclicktype", DummyCommand); // DoubleClickTypeAction
            Interpreter.RegisterCommandHandler("dclick", DummyCommand); //DoubleClickAction

            Interpreter.RegisterCommandHandler("usetype", DummyCommand); // DoubleClickTypeAction
            Interpreter.RegisterCommandHandler("useobject", DummyCommand); //DoubleClickAction

            // Moving stuff
            Interpreter.RegisterCommandHandler("drop", DummyCommand); //DropAction
            Interpreter.RegisterCommandHandler("droprelloc", DummyCommand); //DropAction
            Interpreter.RegisterCommandHandler("lift", DummyCommand); //LiftAction
            Interpreter.RegisterCommandHandler("lifttype", DummyCommand); //LiftTypeAction

            // Gump
            Interpreter.RegisterCommandHandler("waitforgump", DummyCommand); // WaitForGumpAction
            Interpreter.RegisterCommandHandler("gumpresponse", DummyCommand); // GumpResponseAction
            Interpreter.RegisterCommandHandler("gumpclose", DummyCommand); // GumpResponseAction

            // Menu
            Interpreter.RegisterCommandHandler("menu", DummyCommand); //ContextMenuAction
            Interpreter.RegisterCommandHandler("menuresponse", DummyCommand); //MenuResponseAction
            Interpreter.RegisterCommandHandler("waitformenu", DummyCommand); //WaitForMenuAction

            // Prompt
            Interpreter.RegisterCommandHandler("promptresponse", DummyCommand); //PromptAction
            Interpreter.RegisterCommandHandler("waitforprompt", DummyCommand); //WaitForPromptAction

            // Hotkey execution
            Interpreter.RegisterCommandHandler("hotkey", DummyCommand); //HotKeyAction

            // Messages
            Interpreter.RegisterCommandHandler("say", DummyCommand); //SpeechAction
            Interpreter.RegisterCommandHandler("msg", DummyCommand); //SpeechAction
            Interpreter.RegisterCommandHandler("overhead", DummyCommand); //OverheadMessageAction
            Interpreter.RegisterCommandHandler("headmsg", DummyCommand); //OverheadMessageAction
            Interpreter.RegisterCommandHandler("sysmsg", DummyCommand); //SystemMessageAction

            // General Waits/Pauses
            Interpreter.RegisterCommandHandler("wait", DummyCommand); //PauseAction
            Interpreter.RegisterCommandHandler("pause", DummyCommand); //PauseAction

            // Misc
            Interpreter.RegisterCommandHandler("setability", DummyCommand); //SetAbilityAction
            Interpreter.RegisterCommandHandler("setlasttarget", DummyCommand); //SetLastTargetAction
            Interpreter.RegisterCommandHandler("lasttarget", DummyCommand); //LastTargetAction
            Interpreter.RegisterCommandHandler("skill", DummyCommand); //SkillAction
            Interpreter.RegisterCommandHandler("useskill", DummyCommand); //SkillAction
            Interpreter.RegisterCommandHandler("walk", DummyCommand); //Move/WalkAction
            Interpreter.RegisterCommandHandler("potion", DummyCommand);

            // Script related
            Interpreter.RegisterCommandHandler("script", DummyCommand);
            Interpreter.RegisterCommandHandler("setvar", DummyCommand);
            Interpreter.RegisterCommandHandler("setvariable", DummyCommand);

            Interpreter.RegisterCommandHandler("stop", DummyCommand);


            // Expressions
            Interpreter.RegisterExpressionHandler("stam", DummyExpression);
            Interpreter.RegisterExpressionHandler("maxstam", DummyExpression);
            Interpreter.RegisterExpressionHandler("hp", DummyExpression);
            Interpreter.RegisterExpressionHandler("hits", DummyExpression);
            Interpreter.RegisterExpressionHandler("maxhp", DummyExpression);
            Interpreter.RegisterExpressionHandler("maxhits", DummyExpression);
            Interpreter.RegisterExpressionHandler("mana", DummyExpression);
            Interpreter.RegisterExpressionHandler("maxmana", DummyExpression);
            Interpreter.RegisterExpressionHandler("poisoned", DummyExpression);
            Interpreter.RegisterExpressionHandler("hidden", DummyExpression);

            Interpreter.RegisterExpressionHandler("mounted", DummyExpression);
            Interpreter.RegisterExpressionHandler("rhandempty", DummyExpression);
            Interpreter.RegisterExpressionHandler("lhandempty", DummyExpression);

            Interpreter.RegisterExpressionHandler("dead", DummyExpression);

            Interpreter.RegisterExpressionHandler("str", DummyExpression);
            Interpreter.RegisterExpressionHandler("int", DummyExpression);
            Interpreter.RegisterExpressionHandler("dex", DummyExpression);

            Interpreter.RegisterExpressionHandler("weight", DummyExpression);

            Interpreter.RegisterExpressionHandler("skill", DummyExpression);
            Interpreter.RegisterExpressionHandler("count", DummyExpression);
            Interpreter.RegisterExpressionHandler("counter", DummyExpression);

            Interpreter.RegisterExpressionHandler("insysmsg", DummyExpression);
            Interpreter.RegisterExpressionHandler("insysmessage", DummyExpression);

            Interpreter.RegisterExpressionHandler("findtype", DummyExpression);


            // Aliases
            Interpreter.RegisterAliasHandler("backpack", DummyAlias);
            Interpreter.RegisterAliasHandler("last", DummyAlias);
            Interpreter.RegisterAliasHandler("lasttarget", DummyAlias);
            Interpreter.RegisterAliasHandler("lastobject", DummyAlias);
            Interpreter.RegisterAliasHandler("self", DummyAlias);
            Interpreter.RegisterAliasHandler("righthand", DummyAlias);
            Interpreter.RegisterAliasHandler("lefthand", DummyAlias);
            Interpreter.RegisterAliasHandler("hand", DummyAlias);

        }
    }
}