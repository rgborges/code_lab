def logger(function):
      def wrapper(*args, **kargs):
            print(f"--{function.__name__}: start")
            output = function(*args, **kargs)
            print(f"--{function.__name__}: end")
            return output
      return wrapper

@logger
def dummy_function(text):
      print(text)



dummy_function("hey decorator!")