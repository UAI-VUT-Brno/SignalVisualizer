# SignalVisualizer

A C# WPF application designed to simulate and visualize composite periodic signals in real time. Built for mechanical engineering students learning software practices, version control, and signal processing basics.

---

## Features

* **Dual-Frequency Signal Mixing:** Input custom amplitudes and frequencies for two separate sine waves:
  $$y(t) = A_1 \sin(2\pi f_1 t) + A_2 \sin(2\pi f_2 t)$$
* **Real-time Graphical Interface:** Built with WPF and high-performance graphing via ScottPlot.
* **Playback Controls:** Interactive **Play**, **Pause**, and **Reset** capabilities to analyze signal propagation over time.

---

## Prerequisites

* [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later
* [Visual Studio Code](https://code.visualstudio.com/) (with *C# Dev Kit* extension recommended)

---

## Getting Started

### 1. Clone the Repository

```bash
git clone [https://github.com/UAI-VUT-Brno/SignalVisualizer.git](https://github.com/UAI-VUT-Brno/SignalVisualizer.git)
cd SignalVisualizer