# This code is to control the input to the pretrained model
import torch
from transformers import pipeline

model_id = "meta-llama/Llama-3.2-1B"

# Read token
read_token = None #  Replace with your read token
write_token = None

pipe = pipeline("text-generation",
                model = model_id,
                torch_dtype = torch.bfloat16,
                device_map = "auto",
                token=read_token)

outputs = pipe("hi there, how does the transformer library know from where to donwload the model ?")
for output in outputs:
    print(output['generated_text'])