# 規約

## コード
- C# は `PascalCase`（メソッド・プロパティ）、`_camelCase`（private field）
- Godot のシグナル名は `snake_case`（Godot 慣習に合わせる）
- `partial class` で Godot 生成コードとユーザコードを分離

## ファイル
- 1 ファイル 1 クラス
- シーン (`.tscn`) とスクリプト (`.cs`) は同名で対応

## コミット
- prefix: `feat:` / `fix:` / `refactor:` / `docs:` / `chore:`
- 日本語可、命令形

## ワークフロー
- 編集前に差分を提示
- タスク完了後に `docs/state.md` を更新
- headless で動作確認できないものは作らない
