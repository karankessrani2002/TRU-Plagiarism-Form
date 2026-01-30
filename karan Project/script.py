import sys
import os

def check(file_path, search_term):
    base_name = os.path.basename(file_path).lower()
    step = None
    results = []

    if "form2" in base_name:
        step = "form2"
    elif "form3" in base_name:
        step = "form3"
    elif "form4" in base_name:
        step = "form4"
    elif "form5" in base_name:
        step = "form5"
    elif "form6" in base_name:
        step = "form6"

  
    with open(file_path, 'r') as file:
        content = file.read()
        if search_term.lower() in content.lower():
            results.append((step, file_path))

    return results

search_term = sys.argv[-1]
found_results = []
for file_name in sys.argv[1:-1]:
    found_results.extend(check(file_name, search_term))

for result in found_results:
    print(f"The term '{search_term}' was found in {result[0]} in file: {result[1]}")
