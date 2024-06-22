# Simple Knowledge Graph
This is an experimental minimalist representation of domain-specific knowledge graph (KG) elements. These elements include classes, properties, and relationships as a knowledge graph suitable for computation on ontologies.
Elements are given unique identifiers so that ontologies may be linked and artifacts characterising examples - for example, images of instance of a class - may be associated.

## Architecture
This repository holds 
- representation of a domain as a graph with domain, class, property nodes plus built-in is-a and has-a and domain-specific relationship edges.
-  an API
-  a KG store interface library
-  support for cross-domain references
-  support for linkages between images, audio, and other artifacts and KG elements.

## Links
The API supports create, read, update, and delete operations on KG elements. There are also utility functions to supply unique IDs, render a domain or a domain sub-graph.
