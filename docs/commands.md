# コマンド

すべて headless 前提。PowerShell から実行。

## ビルド
- `dotnet build` — C# ビルド
- `godot --headless --build-solutions --quit-after 2` — Godot 経由でビルド

## インポート / チェック
- `godot --headless --import` — リソースインポート
- `godot --headless --check-only path/to/script.gd` — 構文チェック

## 実行
- `godot --headless --quit-after <フレーム数>` — シーン起動 → 自動終了
- `godot --headless -s path/to/script.cs` — スクリプト直接実行

## テスト
- `dotnet test` — .NET テスト

## バージョン確認
- `godot --version`
- `dotnet --info`
