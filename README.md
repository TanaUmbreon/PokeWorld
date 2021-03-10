# PokeWorld

本家pkmnのシステムを真似してみたかった。

## プロジェクト構成

- [**PokeWorld**](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld): 本体。
  - [Models](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Models): pkmnのゲームシステムにて、不変(Immutable)なオブジェクトをモデル化したもの。
    - [Static](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Models/Static): 永続化ストレージのデータをモデル化したもの。
  - [Repositories](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Repositories): 永続化されたストレージへのデータアクセスを抽象化したもの。
  - [Infrastracures](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Infrastracures): 永続化されたストレージへの具体的なデータアクセスを実装したもの。
- [**PokeWorld.Test**](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld.Test): 自動テスト用のプロジェクト。本体の実装が仕様通りであることを保証する為のもの。NUnitを使用。

## 