//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Projects\vsRepos\Laba1\Calc.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Laba1 {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CalcParser : Parser {
	public const int
		T__0=1, NUMBER=2, IDENTIFIER=3, INT=4, EXPONENT=5, MULTIPLY=6, DIVIDE=7, 
		SUBTRACT=8, ADD=9, LPAREN=10, RPAREN=11, MMIN=12, MMAX=13, MIN=14, MAX=15, 
		DESP=16, INC=17, DEC=18, SEM=19, WS=20;
	public const int
		RULE_compileUnit = 0, RULE_expression = 1, RULE_arglist = 2;
	public static readonly string[] ruleNames = {
		"compileUnit", "expression", "arglist"
	};

	private static readonly string[] _LiteralNames = {
		null, "'%'", null, null, null, "'^'", "'*'", "'/'", "'-'", "'+'", "'('", 
		"')'", "'mmin'", "'mmax'", "'min'", "'max'", "','", "'++'", "'--'", "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "NUMBER", "IDENTIFIER", "INT", "EXPONENT", "MULTIPLY", "DIVIDE", 
		"SUBTRACT", "ADD", "LPAREN", "RPAREN", "MMIN", "MMAX", "MIN", "MAX", "DESP", 
		"INC", "DEC", "SEM", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Calc.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public CalcParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class CompileUnitContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(CalcParser.Eof, 0); }
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompileUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_compileUnit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 6; expression(0);
			State = 7; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class MminContext : ExpressionContext {
		public ArglistContext paramlist;
		public ITerminalNode LPAREN() { return GetToken(CalcParser.LPAREN, 0); }
		public ArglistContext arglist() {
			return GetRuleContext<ArglistContext>(0);
		}
		public MminContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterMmin(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitMmin(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMmin(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DecExprContext : ExpressionContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode DEC() { return GetToken(CalcParser.DEC, 0); }
		public DecExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterDecExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitDecExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDecExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IncExprContext : ExpressionContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode INC() { return GetToken(CalcParser.INC, 0); }
		public IncExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterIncExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitIncExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIncExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class UnaryPlusContext : ExpressionContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public UnaryPlusContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterUnaryPlus(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitUnaryPlus(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnaryPlus(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class UnaryMinusContext : ExpressionContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public UnaryMinusContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterUnaryMinus(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitUnaryMinus(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnaryMinus(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MaxMinExprContext : ExpressionContext {
		public IToken operatorToken;
		public ITerminalNode LPAREN() { return GetToken(CalcParser.LPAREN, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode SEM() { return GetToken(CalcParser.SEM, 0); }
		public ITerminalNode RPAREN() { return GetToken(CalcParser.RPAREN, 0); }
		public ITerminalNode MAX() { return GetToken(CalcParser.MAX, 0); }
		public ITerminalNode MIN() { return GetToken(CalcParser.MIN, 0); }
		public MaxMinExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterMaxMinExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitMaxMinExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMaxMinExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MultiplicativeExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode MULTIPLY() { return GetToken(CalcParser.MULTIPLY, 0); }
		public ITerminalNode DIVIDE() { return GetToken(CalcParser.DIVIDE, 0); }
		public MultiplicativeExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterMultiplicativeExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitMultiplicativeExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiplicativeExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ExponentialExprContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode EXPONENT() { return GetToken(CalcParser.EXPONENT, 0); }
		public ExponentialExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterExponentialExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitExponentialExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExponentialExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MmaxContext : ExpressionContext {
		public ArglistContext paramlist;
		public ITerminalNode LPAREN() { return GetToken(CalcParser.LPAREN, 0); }
		public ArglistContext arglist() {
			return GetRuleContext<ArglistContext>(0);
		}
		public MmaxContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterMmax(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitMmax(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMmax(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AdditiveExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode ADD() { return GetToken(CalcParser.ADD, 0); }
		public ITerminalNode SUBTRACT() { return GetToken(CalcParser.SUBTRACT, 0); }
		public AdditiveExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterAdditiveExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitAdditiveExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAdditiveExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NumberExprContext : ExpressionContext {
		public ITerminalNode NUMBER() { return GetToken(CalcParser.NUMBER, 0); }
		public NumberExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterNumberExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitNumberExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumberExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IdentifierExprContext : ExpressionContext {
		public ITerminalNode IDENTIFIER() { return GetToken(CalcParser.IDENTIFIER, 0); }
		public IdentifierExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterIdentifierExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitIdentifierExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifierExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenthesizedExprContext : ExpressionContext {
		public ITerminalNode LPAREN() { return GetToken(CalcParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(CalcParser.RPAREN, 0); }
		public ParenthesizedExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterParenthesizedExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitParenthesizedExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenthesizedExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ModExprContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ModExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterModExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitModExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitModExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DespExprContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode DESP() { return GetToken(CalcParser.DESP, 0); }
		public DespExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterDespExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitDespExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDespExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 33;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case LPAREN:
				{
				_localctx = new ParenthesizedExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 10; Match(LPAREN);
				State = 11; expression(0);
				State = 12; Match(RPAREN);
				}
				break;
			case SUBTRACT:
				{
				_localctx = new UnaryMinusContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 14; Match(SUBTRACT);
				State = 15; expression(13);
				}
				break;
			case ADD:
				{
				_localctx = new UnaryPlusContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 16; Match(ADD);
				State = 17; expression(12);
				}
				break;
			case NUMBER:
				{
				_localctx = new NumberExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 18; Match(NUMBER);
				}
				break;
			case IDENTIFIER:
				{
				_localctx = new IdentifierExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 19; Match(IDENTIFIER);
				}
				break;
			case MIN:
			case MAX:
				{
				_localctx = new MaxMinExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 20;
				((MaxMinExprContext)_localctx).operatorToken = _input.Lt(1);
				_la = _input.La(1);
				if ( !(_la==MIN || _la==MAX) ) {
					((MaxMinExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 21; Match(LPAREN);
				State = 22; expression(0);
				State = 23; Match(SEM);
				State = 24; expression(0);
				State = 25; Match(RPAREN);
				}
				break;
			case MMIN:
				{
				_localctx = new MminContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 27; Match(MMIN);
				State = 28; Match(LPAREN);
				State = 29; ((MminContext)_localctx).paramlist = arglist();
				}
				break;
			case MMAX:
				{
				_localctx = new MmaxContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 30; Match(MMAX);
				State = 31; Match(LPAREN);
				State = 32; ((MmaxContext)_localctx).paramlist = arglist();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.Lt(-1);
			State = 56;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 54;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
					case 1:
						{
						_localctx = new DespExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 35;
						if (!(Precpred(_ctx, 14))) throw new FailedPredicateException(this, "Precpred(_ctx, 14)");
						State = 36; Match(DESP);
						State = 37; expression(15);
						}
						break;

					case 2:
						{
						_localctx = new ModExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 38;
						if (!(Precpred(_ctx, 11))) throw new FailedPredicateException(this, "Precpred(_ctx, 11)");
						State = 39; Match(T__0);
						State = 40; expression(12);
						}
						break;

					case 3:
						{
						_localctx = new ExponentialExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 41;
						if (!(Precpred(_ctx, 10))) throw new FailedPredicateException(this, "Precpred(_ctx, 10)");
						State = 42; Match(EXPONENT);
						State = 43; expression(11);
						}
						break;

					case 4:
						{
						_localctx = new MultiplicativeExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 44;
						if (!(Precpred(_ctx, 9))) throw new FailedPredicateException(this, "Precpred(_ctx, 9)");
						State = 45;
						((MultiplicativeExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==MULTIPLY || _la==DIVIDE) ) {
							((MultiplicativeExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 46; expression(10);
						}
						break;

					case 5:
						{
						_localctx = new AdditiveExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 47;
						if (!(Precpred(_ctx, 8))) throw new FailedPredicateException(this, "Precpred(_ctx, 8)");
						State = 48;
						((AdditiveExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==SUBTRACT || _la==ADD) ) {
							((AdditiveExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 49; expression(9);
						}
						break;

					case 6:
						{
						_localctx = new IncExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 50;
						if (!(Precpred(_ctx, 4))) throw new FailedPredicateException(this, "Precpred(_ctx, 4)");
						State = 51; Match(INC);
						}
						break;

					case 7:
						{
						_localctx = new DecExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 52;
						if (!(Precpred(_ctx, 3))) throw new FailedPredicateException(this, "Precpred(_ctx, 3)");
						State = 53; Match(DEC);
						}
						break;
					}
					} 
				}
				State = 58;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ArglistContext : ParserRuleContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode[] SEM() { return GetTokens(CalcParser.SEM); }
		public ITerminalNode SEM(int i) {
			return GetToken(CalcParser.SEM, i);
		}
		public ArglistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arglist; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterArglist(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitArglist(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArglist(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ArglistContext arglist() {
		ArglistContext _localctx = new ArglistContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_arglist);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 59; expression(0);
			State = 62;
			_errHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 60; Match(SEM);
					State = 61; expression(0);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 64;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 14);

		case 1: return Precpred(_ctx, 11);

		case 2: return Precpred(_ctx, 10);

		case 3: return Precpred(_ctx, 9);

		case 4: return Precpred(_ctx, 8);

		case 5: return Precpred(_ctx, 4);

		case 6: return Precpred(_ctx, 3);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x16\x45\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3$\n\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\a\x3\x39\n\x3\f\x3\xE\x3<\v\x3\x3"+
		"\x4\x3\x4\x3\x4\x6\x4\x41\n\x4\r\x4\xE\x4\x42\x3\x4\x2\x2\x3\x4\x5\x2"+
		"\x2\x4\x2\x6\x2\x2\x5\x3\x2\x10\x11\x3\x2\b\t\x3\x2\n\vP\x2\b\x3\x2\x2"+
		"\x2\x4#\x3\x2\x2\x2\x6=\x3\x2\x2\x2\b\t\x5\x4\x3\x2\t\n\a\x2\x2\x3\n\x3"+
		"\x3\x2\x2\x2\v\f\b\x3\x1\x2\f\r\a\f\x2\x2\r\xE\x5\x4\x3\x2\xE\xF\a\r\x2"+
		"\x2\xF$\x3\x2\x2\x2\x10\x11\a\n\x2\x2\x11$\x5\x4\x3\xF\x12\x13\a\v\x2"+
		"\x2\x13$\x5\x4\x3\xE\x14$\a\x4\x2\x2\x15$\a\x5\x2\x2\x16\x17\t\x2\x2\x2"+
		"\x17\x18\a\f\x2\x2\x18\x19\x5\x4\x3\x2\x19\x1A\a\x15\x2\x2\x1A\x1B\x5"+
		"\x4\x3\x2\x1B\x1C\a\r\x2\x2\x1C$\x3\x2\x2\x2\x1D\x1E\a\xE\x2\x2\x1E\x1F"+
		"\a\f\x2\x2\x1F$\x5\x6\x4\x2 !\a\xF\x2\x2!\"\a\f\x2\x2\"$\x5\x6\x4\x2#"+
		"\v\x3\x2\x2\x2#\x10\x3\x2\x2\x2#\x12\x3\x2\x2\x2#\x14\x3\x2\x2\x2#\x15"+
		"\x3\x2\x2\x2#\x16\x3\x2\x2\x2#\x1D\x3\x2\x2\x2# \x3\x2\x2\x2$:\x3\x2\x2"+
		"\x2%&\f\x10\x2\x2&\'\a\x12\x2\x2\'\x39\x5\x4\x3\x11()\f\r\x2\x2)*\a\x3"+
		"\x2\x2*\x39\x5\x4\x3\xE+,\f\f\x2\x2,-\a\a\x2\x2-\x39\x5\x4\x3\r./\f\v"+
		"\x2\x2/\x30\t\x3\x2\x2\x30\x39\x5\x4\x3\f\x31\x32\f\n\x2\x2\x32\x33\t"+
		"\x4\x2\x2\x33\x39\x5\x4\x3\v\x34\x35\f\x6\x2\x2\x35\x39\a\x13\x2\x2\x36"+
		"\x37\f\x5\x2\x2\x37\x39\a\x14\x2\x2\x38%\x3\x2\x2\x2\x38(\x3\x2\x2\x2"+
		"\x38+\x3\x2\x2\x2\x38.\x3\x2\x2\x2\x38\x31\x3\x2\x2\x2\x38\x34\x3\x2\x2"+
		"\x2\x38\x36\x3\x2\x2\x2\x39<\x3\x2\x2\x2:\x38\x3\x2\x2\x2:;\x3\x2\x2\x2"+
		";\x5\x3\x2\x2\x2<:\x3\x2\x2\x2=@\x5\x4\x3\x2>?\a\x15\x2\x2?\x41\x5\x4"+
		"\x3\x2@>\x3\x2\x2\x2\x41\x42\x3\x2\x2\x2\x42@\x3\x2\x2\x2\x42\x43\x3\x2"+
		"\x2\x2\x43\a\x3\x2\x2\x2\x6#\x38:\x42";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Laba1