# 🌐 IP Info Viewer

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![WPF](https://img.shields.io/badge/WPF-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![API](https://img.shields.io/badge/IP-API.com-FF6F00?style=for-the-badge)](https://ip-api.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)

> **IP Info Viewer** — это десктопное приложение на C# WPF, которое позволяет быстро получить детальную информацию о любом IP-адресе. Программа отправляет запрос к публичному API и отображает данные в удобном интерфейсе.

---

## 🚀 Возможности

- ✅ **Проверка любого IP-адреса** — введите любой IPv4-адрес и получите полную информацию о нём
- ✅ **Определение вашего IP** — отправьте `0.0.0.0` или оставьте поле пустым, и программа вернёт информацию о вашем IP-адресе
- ✅ **Детальная информация**:
  - 🌍 **IP-адрес**
  - 🏙️ **Город**
  - 🗺️ **Регион** (область/штат)
  - 🇺🇳 **Страна**
  - 📍 **Координаты** (широта и долгота)
  - 🏢 **Организация** (провайдер)
  - 📮 **Почтовый индекс**
  - 🕐 **Часовой пояс**
- ✅ **Простой и понятный интерфейс** — вся информация структурирована в удобном виде
- ✅ **Обработка ошибок** — программа корректно реагирует на неверные IP-адреса и проблемы с сетью
- ✅ **Асинхронные запросы** — интерфейс не зависает во время загрузки данных
- ✅ **Валидация ввода** — проверка корректности введённого IP-адреса

---

## 🖼️ Скриншоты

| Главное окно | Результат запроса |
|--------------|-------------------|
| *(вставьте сюда скриншот главного окна)* | *(вставьте сюда скриншот с результатом)* |

---

## 📦 Установка

### Требования
- Windows 7 / 8 / 10 / 11
- [.NET 6.0+](https://dotnet.microsoft.com/en-us/download) (или .NET Core 3.1)

### Скачать готовую версию
1. Перейдите в раздел [Releases](https://github.com/ваш_ник/IPInfoViewer/releases)
2. Скачайте последнюю версию `IPInfoViewer.zip`
3. Распакуйте архив в любую папку
4. Запустите `IPInfoViewer.exe`

### Сборка из исходников
```bash
git clone https://github.com/ваш_ник/IPInfoViewer.git
cd IPInfoViewer
dotnet restore
dotnet build --configuration Release