
SOURCE_DATA_PATH = 'standard_rotation_matrices.txt'
OUT_PATH = 'matrix_code.txt'
FORMAT_STR = 'BASIC_EQUATIONS[{},{},{}] = (c1, s1, c2, s2, c3, s3) => Zip({});'
AXIS_ID_MAP = {'x':0,'y':1,'z':2}

def get_file_content(path):
    f = open(path, 'r')
    content = f.read()
    f.close()
    return content

def write_to_file(path, content):
    f = open(path, 'w')
    f.write(content)
    f.close()

def split_id(axis_names):
    return [AXIS_ID_MAP[axis_name] for axis_name in axis_names]

def convert_sec(sec):
    out_str = ''
    step = 0
    length = len(sec)
    for i in range(length):
        c = sec[i]
        if c == '-' or c == '+':
            out_str += c
        else:
            out_str += c
            step += 1
            if step % 2 == 0 and i < length-1 and (sec[i+1] == 's' or sec[i+1] == 'c'):
                out_str += '*'
    return out_str

def convert_single(block):
    matrix_id = split_id(block[0])
    items = []
    for i in range(1, len(block)):
        line = block[i]
        for sec in line.split(' '):
            sec_str = convert_sec(sec)
            items.append(sec_str)
    all_items = ','.join(items)
    out_str = FORMAT_STR.format(matrix_id[0], matrix_id[1], matrix_id[2], all_items)
    print(out_str)
    return out_str

def main():
    source_str = get_file_content(SOURCE_DATA_PATH)
    source_str = source_str.replace('\r','')
    blocks = source_str.split('\n\n')
    blocks = [block.splitlines() for block in blocks]
    out_str = ''
    for block in blocks:
        if len(block) == 4:
            single_code = convert_single(block)
            out_str += single_code + '\n'
    if len(out_str) > 0:
        write_to_file(OUT_PATH, out_str)

main()
