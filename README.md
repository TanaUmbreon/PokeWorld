# PokeWorld

本家pkmnのシステムを真似してみたかった。

## プロジェクト構成・フォルダー構成

「ドメイン」は、当プログラムで実装対象となるゲームシステムそのもののこと。

- [**PokeWorld**](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld): ゲームシステム本体のプロジェクト。
  - [Common](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Common): ドメインに依存しない、汎用的なオブジェクト群。
  - [Models](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Models): ドメイン固有のロジック(後述のドメインサービス)で扱う為の要素を定義したもの。ドメインモデル。ドメインと対になるようにデータをまとめ、命名する。データの操作に必要なメソッドも実装する。
  - [Repositories](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Repositories): 永続化ストレージに保存されているドメインモデルのデータに対して、読み込みや書き込みといった操作を定義したもの。ここではインタフェースのみの提供となり、具体的な実装には依存しない。
  - [Services](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Services): ドメイン固有のロジックを実装したもの。ドメインサービス。
  - [ApplicationServices](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/ApplicationServices): ドメイン固有のロジックを実装したもの。アプリケーションサービス。
  - [Infrastracures](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Infrastracures): 永続化ストレージへの具体的なデータアクセスを実装したもの。
  - [Schemas](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Schemas): JSON形式で定義された静的データやローカライズデータの構造を定義したJSONスキーマを格納するデータフォルダー。
  - [Static](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Static): JSON形式で定義された静的データを格納するデータフォルダー。
  - [Localize](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld/Localize): JSON形式で定義されたローカライズデータを格納するデータフォルダー。
- [**PokeWorld.Test**](https://github.com/TanaUmbreon/PokeWorld/tree/master/PokeWorld.Test): 自動テスト用のプロジェクト。本体の実装が仕様通りであることを保証する為のもの。NUnitを使用。

## 階層ごとの依存関係

`Common` ← `Models` ← `Repositories` ← `Services` ← `Infrastractures`

矢印の逆方向への参照は禁止する。
同階層もしくは矢印方向への参照は許可する。
