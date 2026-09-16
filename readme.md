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
git clone https://github.com/UAI-VUT-Brno/SignalVisualizer.git
cd SignalVisualizer
```

### 2. Run the Application

```bash
dotnet run --project src/SignalVisualizer
```

## Next Steps - Dataset
The dataset is included as a part part of the project. Name: NASA IMS Bearing Dataset, 2nd_test folder.
Contains couple of 1 second records from 4 sensors measuring the vibration on the bearing. ASCII format, 4 columns, tab separated, 20480 lines per file.

For download if needed: Kaggle
https://www.kaggle.com/datasets/vinayak123tyagi/bearing-dataset?resource=download

2nd_test folder contains 984 files, bearing damage progresses till collapse.
Structure
```Plaintext
2nd_test/
├── 2004.02.12.10.32.39
├── 2004.02.12.10.42.39
├── 2004.02.12.10.52.39
└── ...
```

