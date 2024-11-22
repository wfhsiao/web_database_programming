import whisper from 'whisper.js';

class RealtimeWhisperRecognition {
  constructor(options = {}) {
    this.model = null;
    this.options = {
      modelType: 'tiny', // or 'base' for slightly better accuracy
      language: 'en',
      ...options
    };
  }

  async initializeModel() {
    try {
      // Load the WebAssembly version of Whisper
      this.model = await whisper.load({
        model: this.options.modelType,
        webAssembly: true
      });
    } catch (error) {
      console.error('Failed to load Whisper model:', error);
    }
  }

  async processAudioChunk(audioChunk) {
    if (!this.model) {
      await this.initializeModel();
    }

    try {
      // Process the audio chunk 
      const result = await this.model.transcribe(audioChunk, {
        language: this.options.language,
        // Use these options to optimize for speed
        beam_size: 1, // Reduce beam search size for faster processing
        best_of: 1,   // Reduce alternative hypothesis search
        patience: 0   // Minimize additional processing
      });

      return result.text;
    } catch (error) {
      console.error('Speech recognition error:', error);
      return null;
    }
  }

  // Streaming recognition method
  async startStreamingRecognition(audioStream, onPartialResult) {
    const audioChunks = this.splitAudioStream(audioStream);
    
    for (const chunk of audioChunks) {
      const partialText = await this.processAudioChunk(chunk);
      if (partialText) {
        onPartialResult(partialText);
      }
    }
  }

  // Helper method to split audio stream into processable chunks
  splitAudioStream(audioStream) {
    // Implement logic to split audio stream into smaller chunks
    // This depends on your specific audio capture mechanism
    // Example: split every 1-2 seconds of audio
    const chunkDuration = 1000; // 1 second chunks
    const chunks = [];
    
    // Your audio stream splitting logic here
    return chunks;
  }
}

// Usage example
async function setupSpeechRecognition() {
  const whisperRecognition = new RealtimeWhisperRecognition();
  
  // Initialize the model
  await whisperRecognition.initializeModel();

  // Start capturing audio
  navigator.mediaDevices.getUserMedia({ audio: true })
    .then(stream => {
      whisperRecognition.startStreamingRecognition(
        stream, 
        (partialText) => {
          // Update UI with partial recognition results
          console.log('Partial text:', partialText);
        }
      );
    });
}
