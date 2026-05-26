# アーキテクチャ

## スタック
- Godot 4.6.3 (.NET 版)
- 言語: C# (`Godot.NET.Sdk`)
- ターゲット: Windows Desktop
- 実行モード: headless のみ (GUI 不使用)

## ディレクトリ構成（予定）
- `project.godot` — Godot プロジェクト設定
- `*.csproj` / `*.sln` — .NET プロジェクト
- `scenes/` — `.tscn`
- `scripts/` — C# スクリプト
- `assets/` — リソース
- `tests/` — テスト
- `docs/` — ドキュメント

## 設計方針
- ロジックは C# 側に集約し、Godot 側はシーンの宣言に留める
- headless テスト可能な単位で分離
