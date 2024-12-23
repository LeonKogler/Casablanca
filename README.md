SoftwareDev Tasks:
=======
Task 1:
-------
1. MergeSort Algorithm can be find under: ConsoleApp1/Programm.cs
2. Tests can be find under: TestProject1/TestMergeSort.cs

Task 2:
-------
DomainModel can be found in the DomänenModel.jpg file

Task 3:
-------
OpenAPI Specification file can be found in the openAPISpecification.yml file

NeuralNetwork/RAG/LLM Tasks:
=======
Task 1:
-------
I guess the formula computes the gradient of the lossfunction of the [n-1] hidden layer of the neural network and is part of the backpropagation algorithm.
* Case a) popably indicates that layers at the beginning of the neural net dont get that much effected of the backpropagation then the layers near the output.
* Case b) The propagation effects all layers the same
* Case c) opposite than case a)

Task 2:
---------
The Workflow of the RAG-Application can be found in the RAG-Workflow.pdf

Task 3:
-------
### Methods mentiond in the paper:
* #### Fine-Tuning Language Models From Feedback(RLHF):

Classical RLHF uses policy gradient algorithms, which require online data collection. This makes the approach impractical for general web tasks beyond information retrieval.

* #### Reinforced Fine-Tuning (RFT):
  
While scalable and simple, RFT struggles with tasks requiring deep reasoning and exploration. It performs well as a baseline but often underperforms compared to standard RL approaches.

* #### Direct Preference Optimization (DPO):

DPO is an alternative to classical RLHF optimization and can be used entirely with offline data. Applied to the WebShop environment, the success rate increases to 37.5% compared to 31.3% with the RFT approach.

* #### Monte-Carlo Tree Search (MCTS):

MCTS, typically applied to games like Chess or Go to find the best path for the best outcome, is adapted for the WebAgent. This enables it to search for the optimal action among a variety of different paths. Through iterative processes of selection, expansion, simulation, and backpropagation, MCTS balances exploration and exploitation of various paths. An AgentQ equipped with MCTS enhances results in the simulated WebShop environment by 9%, achieving a success rate of 50.5%, surpassing the average human performance.

### How could you use the results to improve a WebAgent which should plan your next vacation?

By leveraging DPO combined with MCTS applied to the xLAM-v0.1-r base model, the WebAgent could surpass average human performance in planning tasks. These methods demonstrate significant potential, suggesting that AgentQ could be integrated into real-world vacation planning platforms. However, the paper highlights that for safety-critical online transactions—such as communication, payments, or document filings—additional safeguards, including safety critics and human-in-the-loop training, may be necessary to ensure reliability and security.

Task 4:
--------
1. Scaling Laws for Neural Language Models: https://arxiv.org/pdf/2001.08361 
2. GSM-Symbolic: Understanding the Limitations of Mathematical Reasoning in Large Language Models: https://arxiv.org/pdf/2410.05229
3. See What LLMs Cannot Answer: A Self-Challenge Framework for Uncovering LLM Weaknesses: https://arxiv.org/pdf/2408.08978
4. Hallucination is Inevitable: An Innate Limitation of Large Language Models: https://arxiv.org/pdf/2401.11817
5. The Problems of LLM-generated Data in Social Science Research: https://sociologica.unibo.it/article/view/19576/18669

Summary:
========
My strengths lie primarily in software development, where I have solid experience and understanding. In the Neural Network and LLM domains, I have hands-on experience but less theoretical depth.
