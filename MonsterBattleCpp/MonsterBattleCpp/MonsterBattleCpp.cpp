﻿#include <vector>
#include <Windows.h>


// FlatBuffersを使う段階になったら、この値を 1 (0以外) にしよう！
#define USE_FLATBUFFERS 0 


/// モンスターデータ
struct MonsterData
{
	const char* label;      //< ラベル
	const char* name;       //< 名前
	int hp;                 //< 体力
	int ap;                 //< 攻撃力
	int dp;                 //< 防御力
};

/// モンスターリスト
static constexpr MonsterData s_monsterList[] =
{
	// label            name            hp      ap      dp
	{ "demon",      u8"デーモン　", 	800,    40, 	25  },
	{ "dragon", 	u8"ドラゴン　", 	900,	45, 	10  },
	{ "ghost",  	u8"ゴースト　", 	500,    20, 	25  },
	{ "hapry",  	u8"ハーピィ　", 	600,	30, 	20  },
	{ "ninja",	    u8"ニンジャ　",		400,	85, 	20  },
	{ "slime",	    u8"スライム　",		200,	10,	    90  },
	{ "vampire",	u8"バンパイア",		700,	15,	    60  },
	{ "zombie",	    u8"ゾンビ　　",		300,	20,	    30  }
};

// モンスターを強い順に並べなさい
// 
// どのモンスターが強いかは、実際に戦わせて決めます。
// 戦闘は 1 vs 1 で行い、先に力尽きた方が負けです。（力尽きる＝ヒットポイントが0以下になる）
// ステータスの意味は以下の通りです。
// ・hp  残体力
// ・ap  攻撃力（この値がそのまま基礎タメージ値になります）
// ・dp  防御力（この値の分だけ、受ける基礎ダメージの割合を減らします）
// 例）攻撃側の ap が 20 で、防御側の dp が 30 の時は、防御側は 20 の威力の攻撃を 30% 吸収するんで、 14 ダメージを受けます。
// ダメージ値に小数が出た場合は切り捨てられます。（例：1.5 ⇒ 1）
// 2体は同時に戦います。同時に力尽きた時は、力尽きた時の体力が大きい方が勝ちです。（例：残り体力が -20 と -5になった場合は、-5の方が勝ち）
// また、力尽きた時の体力が両者ともに同じ時は、リストの先に並んでた方が勝ちとします。


int main()
{
	// コードページ(文字コード)を UTF-8 にするおまじない
	SetConsoleOutputCP(65001);


#if defined(USE_FLATBUFFERS) && USE_FLATBUFFERS
	// FlatBuffersを使う段階になったら、ここにバイナリにシリアライズされたデータを読み込んで、 monsterList を構築する処理を実装しよう！
	std::vector<MonsterData> monsterList;

#else
	// FlatBuffersを使わない段階では、ココで monsterList が構築される。
	std::vector<MonsterData> monsterList(std::begin(s_monsterList), std::end(s_monsterList));

#endif

	// ソート前の状態を表示
	printf(u8"ソート前\n");
	for (const auto& monster : monsterList)
	{
		printf(u8"  %-10s : HP:%3d, ATK:%2d, DEF:%2d\n", monster.name, monster.hp, monster.ap, monster.dp);
	}
	printf("\n");

	// monsterList を強い順に並べ替える処理をココに実装しよう！
	{
	}

	// ソート後の状態を表示
	printf(u8"ソート後\n");
	for (const auto& monster : monsterList)
	{
		printf(u8"  %-10s : HP:%3d, ATK:%2d, DEF:%2d\n", monster.name, monster.hp, monster.ap, monster.dp);
	}
	printf("\n");
}

