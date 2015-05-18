using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Data {

	public static class Constants {

		#region 艦船・装備

		/// <summary>
		/// 艦船の速力を表す文字列を取得します。
		/// </summary>
		public static string GetSpeed( int value ) {
			switch ( value ) {
				case 0:
					return Properties.Resources.Constant_Land;
				case 5:
					return Properties.Resources.Constant_LowSpeed;
				case 10:
					return Properties.Resources.Constant_HighSpeed;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// 射程を表す文字列を取得します。
		/// </summary>
		public static string GetRange( int value ) {
			switch ( value ) {
				case 0:
					return Properties.Resources.Constant_None;
				case 1:
					return Properties.Resources.Constant_Short;
				case 2:
					return Properties.Resources.Constant_Middle;
				case 3:
					return Properties.Resources.Constant_Long;
				case 4:
					return Properties.Resources.Constant_SuperLong;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// 艦船のレアリティを表す文字列を取得します。
		/// </summary>
		public static string GetShipRarity( int value ) {
			switch ( value ) {
				case 0:
					return Properties.Resources.Constant_Red;
				case 1:
					return Properties.Resources.Constant_Blue;
				case 2:
					return Properties.Resources.Constant_Cyan;
				case 3:
					return Properties.Resources.Constant_AquaBlue;
				case 4:
					return Properties.Resources.Constant_Silver;
				case 5:
					return Properties.Resources.Constant_Golden;
				case 6:
					return Properties.Resources.Constant_Rainbow;
				case 7:
					return Properties.Resources.Constant_BlazeRainbow;
				case 8:
					return Properties.Resources.Constant_SakuraRainbow;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// 装備のレアリティを表す文字列を取得します。
		/// </summary>
		public static string GetEquipmentRarity( int value ) {
			switch ( value ) {
				case 0:
					return Properties.Resources.Constant_Common;
				case 1:
					return Properties.Resources.Constant_Rare;
				case 2:
					return Properties.Resources.Constant_Holo;
				case 3:
					return Properties.Resources.Constant_SHolo;
				case 4:
					return Properties.Resources.Constant_SSHolo;
				case 5:
					return Properties.Resources.Constant_EXHolo;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// 装備のレアリティの画像インデックスを取得します。
		/// </summary>
		public static int GetEquipmentRarityID( int value ) {
			switch ( value ) {
				case 0:
					return 1;
				case 1:
					return 4;
				case 2:
					return 5;
				case 3:
					return 6;
				case 4:
					return 7;
				case 5:
					return 8;
				default:
					return 0;
			}
		}


		/// <summary>
		/// 艦船のボイス設定フラグを表す文字列を取得します。
		/// </summary>
		public static string GetVoiceFlag( int value ) {
			switch ( value ) {
				case 0:
					return "-";
				case 1:
					return Properties.Resources.Constant_Clock;
				case 2:
					return Properties.Resources.Constant_Place;
				case 3:
					return Properties.Resources.Constant_Clock_Place;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}


		/// <summary>
		/// 艦船の損傷度合いを表す文字列を取得します。
		/// </summary>
		/// <param name="hprate">現在HP/最大HPで表される割合。</param>
		/// <param name="isPractice">演習かどうか。</param>
		/// <param name="isLandBase">陸上基地かどうか。</param>
		/// <param name="isEscaped">退避中かどうか。</param>
		/// <returns></returns>
		public static string GetDamageState( double hprate, bool isPractice = false, bool isLandBase = false, bool isEscaped = false ) {

			if ( isEscaped )
				return Properties.Resources.Constant_Escaped;
			else if ( hprate <= 0.0 )
				return isPractice ? Properties.Resources.Constant_Sink_Practice : ( !isLandBase ? Properties.Resources.Constant_Sink : Properties.Resources.Constant_Sink_LandBase );
			else if ( hprate <= 0.25 )
				return !isLandBase ? Properties.Resources.Constant_LowHP : Properties.Resources.Constant_LowHP_LandBase;
			else if ( hprate <= 0.5 )
				return !isLandBase ? Properties.Resources.Constant_HalfHP : Properties.Resources.Constant_HalfHP_LandBase;
			else if ( hprate <= 0.75 )
				return !isLandBase ? Properties.Resources.Constant_HighHP : Properties.Resources.Constant_HighHP_LandBase;
			else if ( hprate < 1.0 )
				return Properties.Resources.Constant_MuchHP;
			else
				return Properties.Resources.Constant_FullHP;

		}

		#endregion


		#region 出撃

		/// <summary>
		/// マップ上のセルでのイベントを表す文字列を取得します。
		/// </summary>
		public static string GetMapEventID( int value ) {

			switch ( value ) {

				case 0:
					return Properties.Resources.Constant_InitialPoint;
				case 1:
					return Properties.Resources.Constant_Null;
				case 2:
					return Properties.Resources.Constant_Resource;
				case 3:
					return Properties.Resources.Constant_Eddy;
				case 4:
					return Properties.Resources.Constant_Battle;
				case 5:
					return Properties.Resources.Constant_BossBattle;
				case 6:
					return Properties.Resources.Constant_Misconception;
				case 7:
					return Properties.Resources.Constant_AirBattle;
				case 8:
					return Properties.Resources.Constant_ShipGuard;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// マップ上のセルでのイベント種別を表す文字列を取得します。
		/// </summary>
		public static string GetMapEventKind( int value ) {

			switch ( value ) {
				case 0:
					return Properties.Resources.Constant_NoBattle;
				case 1:
					return Properties.Resources.Constant_Day_NightBattle;
				case 2:
					return Properties.Resources.Constant_NightBattle;
				case 3:
					return Properties.Resources.Constant_Night_DayBattle;
				case 4:
					return Properties.Resources.Constant_AirBattle;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		#endregion


		#region 戦闘

		/// <summary>
		/// 陣形を表す文字列を取得します。
		/// </summary>
		public static string GetFormation( int id ) {
			switch ( id ) {
				case 1:
					return Properties.Resources.Constant_Information1;
				case 2:
					return Properties.Resources.Constant_Information2;
				case 3:
					return Properties.Resources.Constant_Information3;
				case 4:
					return Properties.Resources.Constant_Information4;
				case 5:
					return Properties.Resources.Constant_Information5;
				case 11:
					return Properties.Resources.Constant_Information11;
				case 12:
					return Properties.Resources.Constant_Information12;
				case 13:
					return Properties.Resources.Constant_Information13;
				case 14:
					return Properties.Resources.Constant_Information14;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// 陣形を表す文字列(短縮版)を取得します。
		/// </summary>
		public static string GetFormationShort( int id ) {
			switch ( id ) {
				case 1:
					return Properties.Resources.Constant_Information1_Short;
				case 2:
					return Properties.Resources.Constant_Information2_Short;
				case 3:
					return Properties.Resources.Constant_Information3_Short;
				case 4:
					return Properties.Resources.Constant_Information4_Short;
				case 5:
					return Properties.Resources.Constant_Information5_Short;
				case 11:
					return Properties.Resources.Constant_Information11_Short;
				case 12:
					return Properties.Resources.Constant_Information12_Short;
				case 13:
					return Properties.Resources.Constant_Information13_Short;
				case 14:
					return Properties.Resources.Constant_Information14_Short;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// 交戦形態を表す文字列を取得します。
		/// </summary>
		public static string GetEngagementForm( int id ) {
			switch ( id ) {
				case 1:
					return Properties.Resources.Constant_Engagement1;
				case 2:
					return Properties.Resources.Constant_Engagement2;
				case 3:
					return Properties.Resources.Constant_Engagement3;
				case 4:
					return Properties.Resources.Constant_Engagement4;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// 索敵結果を表す文字列を取得します。
		/// </summary>
		public static string GetSearchingResult( int id ) {
			switch ( id ) {
				case 1:
					return Properties.Resources.Constant_SearchingResult1;
				case 2:
					return Properties.Resources.Constant_SearchingResult2;
				case 3:
					return Properties.Resources.Constant_SearchingResult3;
				case 4:
					return Properties.Resources.Constant_SearchingResult4;
				case 5:
					return Properties.Resources.Constant_SearchingResult5;
				case 6:
					return Properties.Resources.Constant_SearchingResult6;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// 索敵結果を表す文字列(短縮版)を取得します。
		/// </summary>
		public static string GetSearchingResultShort( int id ) {
			switch ( id ) {
				case 1:
					return Properties.Resources.Constant_SearchingResult1_Short;
				case 2:
					return Properties.Resources.Constant_SearchingResult2_Short;
				case 3:
					return Properties.Resources.Constant_SearchingResult3_Short;
				case 4:
					return Properties.Resources.Constant_SearchingResult4_Short;
				case 5:
					return Properties.Resources.Constant_SearchingResult5_Short;
				case 6:
					return Properties.Resources.Constant_SearchingResult6_Short;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		/// <summary>
		/// 制空戦の結果を表す文字列を取得します。
		/// </summary>
		public static string GetAirSuperiority( int id ) {
			switch ( id ) {
				case 0:
					return Properties.Resources.Constant_AirSuperiority0;
				case 1:
					return Properties.Resources.Constant_AirSuperiority1;
				case 2:
					return Properties.Resources.Constant_AirSuperiority2;
				case 3:
					return Properties.Resources.Constant_AirSuperiority3;
				case 4:
					return Properties.Resources.Constant_AirSuperiority4;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}



		/// <summary>
		/// 昼戦攻撃種別を表す文字列を取得します。
		/// </summary>
		public static string GetDayAttackKind( int id ) {
			switch ( id ) {
				case 0:
					return Properties.Resources.Constant_DayAttackKind0;
				case 1:
					return Properties.Resources.Constant_DayAttackKind1;
				case 2:
					return Properties.Resources.Constant_DayAttackKind2;
				case 3:
					return Properties.Resources.Constant_DayAttackKind3;
				case 4:
					return Properties.Resources.Constant_DayAttackKind4;
				case 5:
					return Properties.Resources.Constant_DayAttackKind5;
				case 6:
					return Properties.Resources.Constant_DayAttackKind6;
				case 7:
					return Properties.Resources.Constant_DayAttackKind7;
				case 8:
					return Properties.Resources.Constant_DayAttackKind8;
				case 9:
					return Properties.Resources.Constant_DayAttackKind9;
				case 10:
					return Properties.Resources.Constant_DayAttackKind10;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}


		/// <summary>
		/// 夜戦攻撃種別を表す文字列を取得します。
		/// </summary>
		public static string GetNightAttackKind( int id ) {
			switch ( id ) {
				case 0:
					return Properties.Resources.Constant_NightAttackKind0;
				case 1:
					return Properties.Resources.Constant_NightAttackKind1;
				case 2:
					return Properties.Resources.Constant_NightAttackKind2;
				case 3:
					return Properties.Resources.Constant_NightAttackKind3;
				case 4:
					return Properties.Resources.Constant_NightAttackKind4;
				case 5:
					return Properties.Resources.Constant_NightAttackKind5;
				case 6:
					return Properties.Resources.Constant_Unknown;
				case 7:
					return Properties.Resources.Constant_NightAttackKind7;
				case 8:
					return Properties.Resources.Constant_NightAttackKind8;
				case 9:
					return Properties.Resources.Constant_NightAttackKind9;
				case 10:
					return Properties.Resources.Constant_NightAttackKind10;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}


		/// <summary>
		/// 対空カットイン種別を表す文字列を取得します。
		/// </summary>
		public static string GetAACutinKind( int id ) {
			switch ( id ) {
				case 0:
					return Properties.Resources.Constant_Null;
				case 1:
					return Properties.Resources.Constant_AACutinKind1;
				case 2:
					return Properties.Resources.Constant_AACutinKind2;
				case 3:
					return Properties.Resources.Constant_AACutinKind3;
				case 4:
					return Properties.Resources.Constant_AACutinKind4;
				case 5:
					return Properties.Resources.Constant_AACutinKind5;
				case 6:
					return Properties.Resources.Constant_AACutinKind6;
				case 7:
					return Properties.Resources.Constant_AACutinKind7;
				case 8:
					return Properties.Resources.Constant_AACutinKind8;
				case 9:
					return Properties.Resources.Constant_AACutinKind9;
				case 10:
					return Properties.Resources.Constant_AACutinKind10;
				case 11:
					return Properties.Resources.Constant_AACutinKind11;
				case 12:
					return Properties.Resources.Constant_AACutinKind12;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}


		/// <summary>
		/// 勝利ランクを表すIDを取得します。
		/// </summary>
		public static int GetWinRank( string rank ) {
			switch ( rank.ToUpper() ) {
				case "E":
					return 1;
				case "D":
					return 2;
				case "C":
					return 3;
				case "B":
					return 4;
				case "A":
					return 5;
				case "S":
					return 6;
				case "SS":
					return 7;
				default:
					return 0;
			}
		}

		/// <summary>
		/// 勝利ランクを表す文字列を取得します。
		/// </summary>
		public static string GetWinRank( int rank ) {
			switch ( rank ) {
				case 1:
					return "E";
				case 2:
					return "D";
				case 3:
					return "C";
				case 4:
					return "B";
				case 5:
					return "A";
				case 6:
					return "S";
				case 7:
					return "SS";
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		#endregion


		#region その他

		/// <summary>
		/// 資源の名前を取得します。
		/// </summary>
		/// <param name="materialID">資源のID。</param>
		/// <returns>資源の名前。</returns>
		public static string GetMaterialName( int materialID ) {

			switch ( materialID ) {
				case 1:
					return Properties.Resources.Constant_Fuel;
				case 2:
					return Properties.Resources.Constant_Ammo;
				case 3:
					return Properties.Resources.Constant_Steel;
				case 4:
					return Properties.Resources.Constant_Bauxite;
				case 5:
					return Properties.Resources.Constant_InstantConstruction;
				case 6:
					return Properties.Resources.Constant_InstantRepair;
				case 7:
					return Properties.Resources.Constant_DevelopmentMaterial;
				case 8:
					return Properties.Resources.Constant_ModdingMaterial;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}


		/// <summary>
		/// 階級を表す文字列を取得します。
		/// </summary>
		public static string GetAdmiralRank( int id ) {
			switch ( id ) {
				case 1:
					return Properties.Resources.Constant_AdmiralRank1;
				case 2:
					return Properties.Resources.Constant_AdmiralRank2;
				case 3:
					return Properties.Resources.Constant_AdmiralRank3;
				case 4:
					return Properties.Resources.Constant_AdmiralRank4;
				case 5:
					return Properties.Resources.Constant_AdmiralRank5;
				case 6:
					return Properties.Resources.Constant_AdmiralRank6;
				case 7:
					return Properties.Resources.Constant_AdmiralRank7;
				case 8:
					return Properties.Resources.Constant_AdmiralRank8;
				case 9:
					return Properties.Resources.Constant_AdmiralRank9;
				case 10:
					return Properties.Resources.Constant_AdmiralRank10;
				default:
					return Properties.Resources.Constant_Admiral;
			}
		}


		/// <summary>
		/// 任務の発生タイプを表す文字列を取得します。
		/// </summary>
		public static string GetQuestType( int id ) {
			switch ( id ) {
				case 1:		//一回限り
					return Properties.Resources.Constant_Once;
				case 2:		//デイリー
					return Properties.Resources.Constant_Day;
				case 3:		//ウィークリー
					return Properties.Resources.Constant_Week;
				case 4:		//敵空母を3隻撃沈せよ！(日付下一桁0|3|7)
					return Properties.Resources.Constant_Vary;
				case 5:		//敵輸送船団を叩け！(日付下一桁2|8)
					return Properties.Resources.Constant_Vary;
				case 6:		//マンスリー
					return Properties.Resources.Constant_Month;
				default:
					return Properties.Resources.Constant_Unknown_Short;
			}

		}


		/// <summary>
		/// 任務のカテゴリを表す文字列を取得します。
		/// </summary>
		public static string GetQuestCategory( int id ) {
			switch ( id ) {
				case 1:
					return Properties.Resources.Constant_Organize;
				case 2:
					return Properties.Resources.Constant_Sortie;
				case 3:
					return Properties.Resources.Constant_Practice;
				case 4:
					return Properties.Resources.Constant_Expedition;
				case 5:
					return Properties.Resources.Constant_Supply_Repair;		//入渠も含むが、文字数の関係
				case 6:
					return Properties.Resources.Constant_Arsenal;
				case 7:
					return Properties.Resources.Constant_Remodel;
				case 8:
					return Properties.Resources.Constant_Other;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}


		/// <summary>
		/// 遠征の結果を表す文字列を取得します。
		/// </summary>
		public static string GetExpeditionResult( int value ) {
			switch ( value ) {
				case 0:
					return Properties.Resources.Constant_Failed;
				case 1:
					return Properties.Resources.Constant_Success;
				case 2:
					return Properties.Resources.Constant_SuperSuccess;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}


		/// <summary>
		/// 連合艦隊の編成名を表す文字列を取得します。
		/// </summary>
		public static string GetCombinedFleet( int value ) {
			switch ( value ) {
				case 0:
					return Properties.Resources.Constant_CombinedFleet0;
				case 1:
					return Properties.Resources.Constant_CombinedFleet1;
				case 2:
					return Properties.Resources.Constant_CombinedFleet2;
				default:
					return Properties.Resources.Constant_Unknown;
			}
		}

		#endregion

	}

}
