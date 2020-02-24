# PokeWorld

本家pkmnのシステムを真似してみたかった。

## プロジェクト構成

- [**PokeWorld**](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld): 本体。
  - [DomainSupport](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/DomainSupport): 実装を簡素化する為の共通コード。pkmnそのものとは無関係。
  - [Statistics](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Statistics): 能力値周りの実装。
- [**PokeWorld.Test**](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld.Test): 自動テスト用のプロジェクト。本体の実装が仕様通りであることを保証する為のもの。NUnitを使用。

## 