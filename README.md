# Documentation

Full API documentation is available here:

- [API Reference](Documentation~/Doxygen/html/index.html)

# Modular Architecture

Modular architecture is a small Unity package designed to provide structured re-usable data-driven pieces of code that can be used and expanded upon in your own Unity projects. Unity's codebase is inherently quite tightly coupled with the reign of Mono Behaviour and whilst it works and the workflow is very simple it has shortcomings. Throughout the years more and more Unity developers have been finding success with encorporating more modular and composite based designs into their Unity work-flows.

### Some Excellent Resources and the inspiration behind this package :

- [Game Architecture with Scriptable Objects](https://www.youtube.com/watch?v=raQ3iHhE_Kk&t=1530s)
- [Overthrowing the MonoBehaviour Tyranny](https://www.youtube.com/watch?v=6vmRwLYWNRo)

### The Benefits to Modularity In Unity

- Fewer dependencies — MonoBehaviour‑heavy setups often create tangled scene references; modular systems stay clean and isolated
-Safer iteration — swapping or updating modules (input, UI, audio, etc.) won’t impact unrelated features
- Easier testing — data‑driven modules avoid scene‑reset issues and reduce dependency headaches
- Better organization — Unity’s asset workflow pairs naturally with ScriptableObjects and persistent data
- Memory efficiency — multiple objects can read from a single data asset, avoiding unnecessary duplication

### Features

- Create-able data assets for IComparable Data Types
- Modular data game event system
- Modular data conditions system ( return a operator b )
- Extendable Enums (Cory Koseck) and Extendable Enum Data Sets
- Custom property drawers
- Samples and Demos
